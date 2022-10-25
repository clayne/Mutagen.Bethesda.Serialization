﻿//HintName: SomeObject_Serializations.g.cs
using Mutagen.Bethesda.Serialization;
using Mutagen.Bethesda.Serialization.SourceGenerator.Tests;

#nullable enable

namespace Mutagen.Bethesda.Serialization.SourceGenerator.Tests;

internal static class SomeObject_Serialization
{
    public static void Serialize<TKernel, TWriteObject>(
        TWriteObject writer,
        Mutagen.Bethesda.Serialization.SourceGenerator.Tests.ISomeObjectGetter item,
        MutagenSerializationWriterKernel<TKernel, TWriteObject> kernel,
        SerializationMetaData metaData)
        where TKernel : ISerializationWriterKernel<TWriteObject>, new()
    {
        kernel.WriteUInt8(writer, "SomeMember0", item.SomeMember0, default(byte));
        kernel.WriteUInt8(writer, "SomeMember1", item.SomeMember1, default(Byte));
        kernel.WriteUInt8(writer, "SomeMember2", item.SomeMember2, default(UInt8));
        kernel.WriteUInt8(writer, "SomeMember3", item.SomeMember3, default(byte?));
        kernel.WriteUInt8(writer, "SomeMember4", item.SomeMember4, default(Byte?));
        kernel.WriteUInt8(writer, "SomeMember5", item.SomeMember5, default(UInt8?));
        kernel.WriteUInt8(writer, "SomeMember6", item.SomeMember6, default(Nullable<byte>));
        kernel.WriteUInt8(writer, "SomeMember7", item.SomeMember7, default(Nullable<Byte>));
        kernel.WriteUInt8(writer, "SomeMember8", item.SomeMember8, default(Nullable<UInt8>));
        kernel.WriteUInt8(writer, "SomeMember9", item.SomeMember9, Mutagen.Bethesda.Serialization.SourceGenerator.Tests.SomeObject.SomeMember9Default);
        kernel.WriteUInt8(writer, "SomeMember10", item.SomeMember10, Mutagen.Bethesda.Serialization.SourceGenerator.Tests.SomeObject.SomeMember10Default);
        kernel.WriteUInt8(writer, "SomeMember11", item.SomeMember11, Mutagen.Bethesda.Serialization.SourceGenerator.Tests.SomeObject.SomeMember11Default);
        kernel.WriteUInt8(writer, "SomeMember12", item.SomeMember12, Mutagen.Bethesda.Serialization.SourceGenerator.Tests.SomeObject.SomeMember12Default);
        kernel.WriteUInt8(writer, "SomeMember13", item.SomeMember13, Mutagen.Bethesda.Serialization.SourceGenerator.Tests.SomeObject.SomeMember13Default);
        kernel.WriteUInt8(writer, "SomeMember14", item.SomeMember14, Mutagen.Bethesda.Serialization.SourceGenerator.Tests.SomeObject.SomeMember14Default);
        kernel.WriteUInt8(writer, "SomeMember15", item.SomeMember15, Mutagen.Bethesda.Serialization.SourceGenerator.Tests.SomeObject.SomeMember15Default);
        kernel.WriteUInt8(writer, "SomeMember16", item.SomeMember16, Mutagen.Bethesda.Serialization.SourceGenerator.Tests.SomeObject.SomeMember16Default);
        kernel.WriteUInt8(writer, "SomeMember17", item.SomeMember17, Mutagen.Bethesda.Serialization.SourceGenerator.Tests.SomeObject.SomeMember17Default);
    }

    public static bool HasSerializationItems(
        Mutagen.Bethesda.Serialization.SourceGenerator.Tests.ISomeObjectGetter item,
        SerializationMetaData metaData)
    {
        if (!EqualityComparer<byte>.Default.Equals(item.SomeMember0, default(byte))) return true;
        if (!EqualityComparer<Byte>.Default.Equals(item.SomeMember1, default(Byte))) return true;
        if (!EqualityComparer<UInt8>.Default.Equals(item.SomeMember2, default(UInt8))) return true;
        if (!EqualityComparer<byte?>.Default.Equals(item.SomeMember3, default(byte?))) return true;
        if (!EqualityComparer<Byte?>.Default.Equals(item.SomeMember4, default(Byte?))) return true;
        if (!EqualityComparer<UInt8?>.Default.Equals(item.SomeMember5, default(UInt8?))) return true;
        if (!EqualityComparer<Nullable<byte>>.Default.Equals(item.SomeMember6, default(Nullable<byte>))) return true;
        if (!EqualityComparer<Nullable<Byte>>.Default.Equals(item.SomeMember7, default(Nullable<Byte>))) return true;
        if (!EqualityComparer<Nullable<UInt8>>.Default.Equals(item.SomeMember8, default(Nullable<UInt8>))) return true;
        if (!EqualityComparer<byte>.Default.Equals(item.SomeMember9, Mutagen.Bethesda.Serialization.SourceGenerator.Tests.SomeObject.SomeMember9Default)) return true;
        if (!EqualityComparer<Byte>.Default.Equals(item.SomeMember10, Mutagen.Bethesda.Serialization.SourceGenerator.Tests.SomeObject.SomeMember10Default)) return true;
        if (!EqualityComparer<UInt8>.Default.Equals(item.SomeMember11, Mutagen.Bethesda.Serialization.SourceGenerator.Tests.SomeObject.SomeMember11Default)) return true;
        if (!EqualityComparer<byte?>.Default.Equals(item.SomeMember12, Mutagen.Bethesda.Serialization.SourceGenerator.Tests.SomeObject.SomeMember12Default)) return true;
        if (!EqualityComparer<Byte?>.Default.Equals(item.SomeMember13, Mutagen.Bethesda.Serialization.SourceGenerator.Tests.SomeObject.SomeMember13Default)) return true;
        if (!EqualityComparer<UInt8?>.Default.Equals(item.SomeMember14, Mutagen.Bethesda.Serialization.SourceGenerator.Tests.SomeObject.SomeMember14Default)) return true;
        if (!EqualityComparer<Nullable<byte>>.Default.Equals(item.SomeMember15, Mutagen.Bethesda.Serialization.SourceGenerator.Tests.SomeObject.SomeMember15Default)) return true;
        if (!EqualityComparer<Nullable<Byte>>.Default.Equals(item.SomeMember16, Mutagen.Bethesda.Serialization.SourceGenerator.Tests.SomeObject.SomeMember16Default)) return true;
        if (!EqualityComparer<Nullable<UInt8>>.Default.Equals(item.SomeMember17, Mutagen.Bethesda.Serialization.SourceGenerator.Tests.SomeObject.SomeMember17Default)) return true;
        return false;
    }

    public static Mutagen.Bethesda.Serialization.SourceGenerator.Tests.SomeObject Deserialize<TReadObject>(
        TReadObject reader,
        ISerializationReaderKernel<TReadObject> kernel,
        SerializationMetaData metaData)
    {
        var obj = new Mutagen.Bethesda.Serialization.SourceGenerator.Tests.SomeObject();
        DeserializeInto<TReadObject>(
            reader: reader,
            kernel: kernel,
            obj: obj,
            metaData: metaData);
        return obj;
    }

    public static void DeserializeInto<TReadObject>(
        TReadObject reader,
        ISerializationReaderKernel<TReadObject> kernel,
        Mutagen.Bethesda.Serialization.SourceGenerator.Tests.ISomeObject obj,
        SerializationMetaData metaData)
    {
        while (kernel.TryGetNextField(reader, out var name))
        {
            switch (name)
            {
                case "SomeMember0":
                    obj.SomeMember0 = kernel.ReadUInt8(reader);
                    break;
                case "SomeMember1":
                    obj.SomeMember1 = kernel.ReadUInt8(reader);
                    break;
                case "SomeMember2":
                    obj.SomeMember2 = kernel.ReadUInt8(reader);
                    break;
                case "SomeMember3":
                    obj.SomeMember3 = kernel.ReadUInt8(reader);
                    break;
                case "SomeMember4":
                    obj.SomeMember4 = kernel.ReadUInt8(reader);
                    break;
                case "SomeMember5":
                    obj.SomeMember5 = kernel.ReadUInt8(reader);
                    break;
                case "SomeMember6":
                    obj.SomeMember6 = kernel.ReadUInt8(reader);
                    break;
                case "SomeMember7":
                    obj.SomeMember7 = kernel.ReadUInt8(reader);
                    break;
                case "SomeMember8":
                    obj.SomeMember8 = kernel.ReadUInt8(reader);
                    break;
                case "SomeMember9":
                    obj.SomeMember9 = kernel.ReadUInt8(reader);
                    break;
                case "SomeMember10":
                    obj.SomeMember10 = kernel.ReadUInt8(reader);
                    break;
                case "SomeMember11":
                    obj.SomeMember11 = kernel.ReadUInt8(reader);
                    break;
                case "SomeMember12":
                    obj.SomeMember12 = kernel.ReadUInt8(reader);
                    break;
                case "SomeMember13":
                    obj.SomeMember13 = kernel.ReadUInt8(reader);
                    break;
                case "SomeMember14":
                    obj.SomeMember14 = kernel.ReadUInt8(reader);
                    break;
                case "SomeMember15":
                    obj.SomeMember15 = kernel.ReadUInt8(reader);
                    break;
                case "SomeMember16":
                    obj.SomeMember16 = kernel.ReadUInt8(reader);
                    break;
                case "SomeMember17":
                    obj.SomeMember17 = kernel.ReadUInt8(reader);
                    break;
                default:
                    break;
            }
        }

    }

}

