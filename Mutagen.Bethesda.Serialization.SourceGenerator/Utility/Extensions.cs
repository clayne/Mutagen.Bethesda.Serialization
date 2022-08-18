﻿using Microsoft.CodeAnalysis;

namespace Mutagen.Bethesda.Serialization.SourceGenerator.Utility;

public static class Extensions
{
    public static ITypeSymbol? TryGetTypeSymbol(this ISymbol? symbol)
    {
        if (symbol is ILocalSymbol local) return local.Type;
        if (symbol is IParameterSymbol param) return param.Type;
        return default;
    }
}