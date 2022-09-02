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
        {
            var listWriter = kernel.StartListSection(writer, "SomeList");
            foreach (var listItem in item.SomeList)
            {
                SomeLoqui_Serialization.Serialize(listItem, listWriter, kernel);
            }
            kernel.EndListSection();
        }
        {
            var listWriter = kernel.StartListSection(writer, "SomeList2");
            foreach (var listItem in item.SomeList2)
            {
                SomeLoqui_Serialization.Serialize(listItem, listWriter, kernel);
            }
            kernel.EndListSection();
        }
        {
            var listWriter = kernel.StartListSection(writer, "SomeList3");
            foreach (var listItem in item.SomeList3)
            {
                SomeLoqui_Serialization.Serialize(listItem, listWriter, kernel);
            }
            kernel.EndListSection();
        }
        {
            var listWriter = kernel.StartListSection(writer, "SomeList4");
            foreach (var listItem in item.SomeList4)
            {
                SomeLoqui_Serialization.Serialize(listItem, listWriter, kernel);
            }
            kernel.EndListSection();
        }
    }

    public static Mutagen.Bethesda.Serialization.SourceGenerator.Tests.ITestModGetter Deserialize<TReadObject>(
        TReadObject reader,
        ISerializationReaderKernel<TReadObject> kernel)
    {
        throw new NotImplementedException();
    }

}
