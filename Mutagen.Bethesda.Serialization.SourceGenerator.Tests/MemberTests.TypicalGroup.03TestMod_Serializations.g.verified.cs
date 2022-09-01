﻿//HintName: TestMod_Serializations.g.cs
using Mutagen.Bethesda.Serialization;
using Mutagen.Bethesda.Serialization.SourceGenerator.Tests;
namespace Mutagen.Bethesda.Serialization.SourceGenerator.Tests;

internal static class TestMod_Serialization
{
    public static void Serialize<TWriteObject>(
        Mutagen.Bethesda.Serialization.SourceGenerator.Tests.ITestModGetter item,
        TWriteObject writer,
        ISerializationWriterKernel<TWriteObject> kernel)
    {
        Group_Serialization.Serialize(item.SomeGroup, writer, kernel);
        foreach (var rec in item.SomeGroup.Records)
        {
            MajorRecord_Serialization.Serialize(rec, writer, kernel);
        }
        Group_Serialization.Serialize(item.SomeGroup2, writer, kernel);
        foreach (var rec in item.SomeGroup2.Records)
        {
            MajorRecord_Serialization.Serialize(rec, writer, kernel);
        }
        Group_Serialization.Serialize(item.SomeGroup3, writer, kernel);
        foreach (var rec in item.SomeGroup3.Records)
        {
            MajorRecord_Serialization.Serialize(rec, writer, kernel);
        }
    }

    public static Mutagen.Bethesda.Serialization.SourceGenerator.Tests.ITestModGetter Deserialize<TReadObject>(
        TReadObject reader,
        ISerializationReaderKernel<TReadObject> kernel)
    {
        throw new NotImplementedException();
    }

}

