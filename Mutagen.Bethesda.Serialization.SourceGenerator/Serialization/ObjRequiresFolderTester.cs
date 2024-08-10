﻿using Microsoft.CodeAnalysis;
using Mutagen.Bethesda.Serialization.SourceGenerator.Customizations;
using Mutagen.Bethesda.Serialization.SourceGenerator.Serialization.Fields;

namespace Mutagen.Bethesda.Serialization.SourceGenerator.Serialization;

public class ObjRequiresFolderTester
{
    private readonly MajorRecordListFieldGenerator _majorRecordListFieldGenerator;

    public ObjRequiresFolderTester(MajorRecordListFieldGenerator majorRecordListFieldGenerator)
    {
        _majorRecordListFieldGenerator = majorRecordListFieldGenerator;
    }

    public bool ObjRequiresFolder(LoquiTypeSet obj, ITypeSymbol typeSymbol, CustomizationCatalog customization)
    {
        if (!customization.Overall.FilePerRecord) return false;
        foreach (var prop in typeSymbol.GetMembers().OfType<IPropertySymbol>())
        {
            if (_majorRecordListFieldGenerator.Applicable(obj, customization, prop.Type, prop.Name))
            {
                return true;
            }
        }

        return false;
    }
}