using Microsoft.CodeAnalysis;
using Noggog.StructuredStrings;
using Noggog.StructuredStrings.CSharp;

namespace Mutagen.Bethesda.Serialization.SourceGenerator.Generator.Fields;

public class LoquiFieldGenerator : ISerializationForFieldGenerator
{
    private readonly IsGroupTester _groupTester;
    private readonly LoquiSerializationNaming _loquiSerializationNaming;
    private readonly IsLoquiObjectTester _isLoquiObjectTester;
    public IEnumerable<string> AssociatedTypes => Enumerable.Empty<string>();

    public LoquiFieldGenerator(
        IsLoquiObjectTester isLoquiObjectTester,
        LoquiSerializationNaming loquiSerializationNaming,
        IsGroupTester groupTester)
    {
        _isLoquiObjectTester = isLoquiObjectTester;
        _loquiSerializationNaming = loquiSerializationNaming;
        _groupTester = groupTester;
    }

    private static HashSet<string> _genericTestTypes = new()
    {
        "IMajorRecordInternal"
    };

    public IEnumerable<string> RequiredNamespaces(ITypeSymbol typeSymbol, CancellationToken cancel) => Enumerable.Empty<string>();

    public bool Applicable(ITypeSymbol typeSymbol)
    {
        if (_groupTester.IsGroup(typeSymbol)) return false;
        if (_isLoquiObjectTester.IsLoqui(typeSymbol)) return true;
        if (typeSymbol is ITypeParameterSymbol typeParameterSymbol)
        {
            if (typeParameterSymbol.ConstraintTypes.Any(x => _genericTestTypes.Contains(x.Name)))
            {
                return true;
            }
        }

        return false;
    }
    
    public void GenerateForSerialize(
        CompilationUnit compilation,
        ITypeSymbol obj,
        ITypeSymbol field, 
        string? fieldName,
        string fieldAccessor,
        string? defaultValueAccessor,
        string writerAccessor,
        string kernelAccessor,
        StructuredStringBuilder sb,
        CancellationToken cancel)
    {
        if (field is ITypeParameterSymbol namedTypeSymbol
            && namedTypeSymbol.ConstraintTypes.Length == 1)
        {
            return;
        }

        if (!_loquiSerializationNaming.TryGetSerializationItems(field, out var fieldSerializationItems)) return;
        if (!compilation.Mapping.TryGetTypeSet(field, out var typeSet)) return;

        var hasInheriting = compilation.Mapping.HasInheritingClasses(typeSet.Getter);

        var call = fieldSerializationItems.SerializationCall(serialize: true, withCheck: hasInheriting);
        
        if (fieldName != null)
        {
            using (var i = sb.If(ands: true))
            {
                i.Add($"{fieldAccessor} is {{}} {fieldName}Checked");
                fieldAccessor = $"{fieldName}Checked";
                i.Add($"{fieldSerializationItems.HasSerializationCall(hasInheriting)}({fieldAccessor})");
            }
        }
        using (sb.CurlyBrace(doIt: fieldName != null))
        {
            sb.AppendLine($"{kernelAccessor}.WriteLoqui({writerAccessor}, {(fieldName == null ? "null" : $"\"{fieldName}\"")}, {fieldAccessor}, static (w, i, k) => {call}<TKernel, TWriteObject>(w, i, k));");
        }
    }

    public bool HasVariableHasSerialize => true;

    public void GenerateForHasSerialize(
        CompilationUnit compilation,
        ITypeSymbol obj,
        ITypeSymbol field,
        string? fieldName,
        string fieldAccessor,
        string? defaultValueAccessor,
        StructuredStringBuilder sb,
        CancellationToken cancel)
    {
        if (!_loquiSerializationNaming.TryGetSerializationItems(field, out var fieldSerializationItems)) return;
        if (!compilation.Mapping.TryGetTypeSet(field, out var typeSet)) return;
        sb.AppendLine($"if ({fieldSerializationItems.HasSerializationCall(withCheck: compilation.Mapping.HasInheritingClasses(typeSet.Getter))}({fieldAccessor})) return true;");
    }

    public void GenerateForDeserialize(
        CompilationUnit compilation,
        ITypeSymbol obj,
        IPropertySymbol propertySymbol,
        string itemAccessor,
        string writerAccessor,
        string kernelAccessor,
        StructuredStringBuilder sb,
        CancellationToken cancel)
    {
        throw new NotImplementedException();
    }
}