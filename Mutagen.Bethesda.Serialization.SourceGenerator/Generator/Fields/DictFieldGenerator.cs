﻿using Microsoft.CodeAnalysis;
using Noggog.StructuredStrings;
using Noggog.StructuredStrings.CSharp;
using StrongInject;

namespace Mutagen.Bethesda.Serialization.SourceGenerator.Generator.Fields;

public class DictFieldGenerator : ISerializationForFieldGenerator
{
    private readonly Func<IOwned<SerializationFieldGenerator>> _forFieldGenerator;
    public IEnumerable<string> AssociatedTypes => Array.Empty<string>();

    public DictFieldGenerator(Func<IOwned<SerializationFieldGenerator>> forFieldGenerator)
    {
        _forFieldGenerator = forFieldGenerator;
    }

    private static readonly HashSet<string> _listStrings = new()
    {
        "Dictionary",
        "IReadOnlyDictionary",
        "IDictionary",
    };

    public bool Applicable(ITypeSymbol typeSymbol)
    {
        if (typeSymbol is not INamedTypeSymbol namedTypeSymbol) return false;
        var typeMembers = namedTypeSymbol.TypeArguments;
        if (typeMembers.Length != 2) return false;
        return _listStrings.Contains(typeSymbol.Name);
    }

    private ITypeSymbol GetSubtype(INamedTypeSymbol t) => t.TypeArguments[0];

    public void GenerateForSerialize(
        ITypeSymbol obj, 
        ITypeSymbol field,
        string? fieldName,
        string fieldAccessor,
        string writerAccessor,
        string kernelAccessor, 
        StructuredStringBuilder sb)
    {
        ITypeSymbol subType;
        if (field is IArrayTypeSymbol arr)
        {
            subType = arr.ElementType;
        }
        else if (field is INamedTypeSymbol namedTypeSymbol)
        {
            subType = GetSubtype(namedTypeSymbol);
        }
        else
        {
            return;
        }

        var dictWriterName = $"{fieldName}DictWriter";
        sb.AppendLine($"var {dictWriterName} = {kernelAccessor}.StartDictionarySection({writerAccessor}, \"{fieldName}\");");
        using (sb.CurlyBrace())
        {
            sb.AppendLine($"foreach (var kv in {fieldAccessor})");
            using (sb.CurlyBrace())
            {
                var dictItemWriterName = "itemWriter";
                var dictKeyWriterName = "keyWriter";
                var dictValueWriterName = "valueWriter";
                sb.AppendLine($"var {dictItemWriterName} = {kernelAccessor}.StartDictionaryItem({dictWriterName});");
                sb.AppendLine($"var {dictKeyWriterName} = {kernelAccessor}.StartDictionaryKey({dictItemWriterName});");
                _forFieldGenerator().Value.GenerateForField(obj, subType, dictKeyWriterName, null, "kv.Key", sb);
                sb.AppendLine($"{kernelAccessor}.StopDictionaryKey();");
                sb.AppendLine($"var {dictValueWriterName} = {kernelAccessor}.StartDictionaryValue({dictItemWriterName});");
                _forFieldGenerator().Value.GenerateForField(obj, subType, dictValueWriterName, null, "kv.Value", sb);
                sb.AppendLine($"{kernelAccessor}.StopDictionaryValue();");
                sb.AppendLine($"{kernelAccessor}.EndDictionaryItem({writerAccessor});");
            }
        }
        sb.AppendLine($"{kernelAccessor}.EndDictionarySection({writerAccessor});");
    }

    public void GenerateForDeserialize(ITypeSymbol obj, IPropertySymbol propertySymbol, string itemAccessor, string writerAccessor,
        string kernelAccessor, StructuredStringBuilder sb)
    {
        throw new NotImplementedException();
    }
}