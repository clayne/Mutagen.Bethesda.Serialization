﻿namespace Mutagen.Bethesda.Serialization.SourceGenerator.Generator.Fields;

public class ModKeyFieldGenerator : PrimitiveFieldGenerator
{
    public static readonly string[] AssociatedTypes = new string[]
    {
        "ModKey",
        "Mutagen.Bethesda.Plugins.ModKey",
    };
    
    public ModKeyFieldGenerator()
        : base("ModKey", AssociatedTypes)
    {
    }
}