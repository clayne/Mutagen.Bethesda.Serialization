﻿//HintName: ITestModGetter_Serializations.g.cs
using Mutagen.Bethesda.Serialization;
using Mutagen.Bethesda.Serialization.SourceGenerator.Tests;
namespace Mutagen.Bethesda.Serialization.SourceGenerator.Tests;

internal static class ITestModGetter_Serialization
{
    public static void Serialize<TWriteObject>(
        Mutagen.Bethesda.Serialization.SourceGenerator.Tests.ITestModGetter item,
        TWriteObject writer,
        ISerializationWriterKernel<TWriteObject> kernel)
    {
        kernel.WriteTranslatedString(writer, "TranslatedString", item.TranslatedString);
        kernel.WriteTranslatedString(writer, "TranslatedString2", item.TranslatedString2);
        kernel.WriteTranslatedString(writer, "TranslatedString3", item.TranslatedString3);
        kernel.WriteTranslatedString(writer, "TranslatedString4", item.TranslatedString4);
        kernel.WriteTranslatedString(writer, "TranslatedString5", item.TranslatedString5);
        kernel.WriteTranslatedString(writer, "TranslatedString6", item.TranslatedString6);
        kernel.WriteTranslatedString(writer, "TranslatedString7", item.TranslatedString7);
        kernel.WriteTranslatedString(writer, "TranslatedString8", item.TranslatedString8);
        kernel.WriteTranslatedString(writer, "TranslatedString9", item.TranslatedString9);
        kernel.WriteTranslatedString(writer, "TranslatedString10", item.TranslatedString10);
        kernel.WriteTranslatedString(writer, "TranslatedString11", item.TranslatedString11);
        kernel.WriteTranslatedString(writer, "TranslatedString12", item.TranslatedString12);
    }

    public static Mutagen.Bethesda.Serialization.SourceGenerator.Tests.ITestModGetter Deserialize<TReadObject>(
        TReadObject reader,
        ISerializationReaderKernel<TReadObject> kernel)
    {
        throw new NotImplementedException();
    }

}

