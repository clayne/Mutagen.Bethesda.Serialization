using Mutagen.Bethesda.Serialization.SourceGenerator.Customizations;
using Mutagen.Bethesda.Serialization.SourceGenerator.Serialization.Bootstrapping;
using Mutagen.Bethesda.Serialization.SourceGenerator.Serialization.Fields;
using StrongInject;

namespace Mutagen.Bethesda.Serialization.SourceGenerator.Serialization;

[Register<SerializationSourceGeneratorInitializer>]
[Register<BootstrapInvocationDetector>]
[Register<StubGenerator>]
[Register<ModInvocationDetector>]
[Register<MixinGenerator>]
[Register<SerializationForObjectsGenerator>]
[Register<RelatedObjectAccumulator>]
[Register<IsLoquiObjectTester>]
[Register<SerializationForObjectGenerator>]
[Register<SerializationFieldGenerator>]
[Register<PropertyFilter>]
[Register<LoquiMapper>]
[Register<LoquiSerializationNaming>]
[Register<LoquiNameRetriever>]
[Register<WhereClauseGenerator>]
[Register<IsGroupTester>]
[Register<IsMajorRecordTester>]
[Register<PropertyCollectionRetriever>]
[Register<ObjectTypeTester>]
[Register<CustomizationDetector>]
[Register<CustomizationInterpreter>]
[Register<CustomizationProvider>]
[Register<RecordCustomizationDetector>]
[Register<RecordCustomizationInterpreter>]
[Register<RecordCustomizationProvider>]
[Register<CustomizationDriver>]
[Register<ReleaseRetriever>]
[Register<ObjRequiresFolderTester>]
[Register<IsLoquiFieldTester>]
[Register<ArgumentRetriever>]
[Register<NamespaceSuffixRetriever>]
[Register<HasFormVersionRetriever>]
[Register<IsListTester>]
[Register(typeof(TranslatedStringFieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(FloatFieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(BoolFieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(GuidFieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(DoubleFieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(LoquiFieldGenerator), typeof(ISerializationForFieldGenerator), typeof(LoquiFieldGenerator))]
[Register(typeof(EnumFieldGenerator), typeof(ISerializationForFieldGenerator), typeof(EnumFieldGenerator))]
[Register(typeof(StringFieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(Int8FieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(Int16FieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(Int32FieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(Int64FieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(UInt8FieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(UInt16FieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(UInt32FieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(UInt64FieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(P2FloatFieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(P3FloatFieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(P3UInt8FieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(P3Int16FieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(P3UInt16FieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(P2IntFieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(P2Int16FieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(P2UInt8FieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(PercentFieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(TimeOnlyFieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(DateOnlyFieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(ListFieldGenerator), typeof(ISerializationForFieldGenerator), typeof(ListFieldGenerator))]
[Register(typeof(MajorRecordListFieldGenerator), typeof(ISerializationForFieldGenerator), typeof(MajorRecordListFieldGenerator))]
[Register(typeof(ModKeyFieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(FormKeyFieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(FormLinkFieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(FormLinkOrIndexFieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(ColorFieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(ByteArrayFieldGenerator), typeof(ISerializationForFieldGenerator), typeof(ByteArrayFieldGenerator))]
[Register(typeof(RecordTypeFieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(GenderedTypeFieldGenerator), typeof(ISerializationForFieldGenerator), typeof(GenderedTypeFieldGenerator))]
[Register(typeof(AssetLinkFieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(DictFieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(SliceListGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(ArrayFieldGenerator), typeof(ISerializationForFieldGenerator), typeof(ArrayFieldGenerator))]
[Register(typeof(GroupFieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(BlocksFieldGenerator), typeof(ISerializationForFieldGenerator), typeof(BlocksFieldGenerator))]
[Register(typeof(BlocksXYFieldMemberBlocker), typeof(ISerializationForFieldGenerator), typeof(BlocksXYFieldMemberBlocker))]
[Register(typeof(BlocksXYFieldGenerator), typeof(ISerializationForFieldGenerator), typeof(BlocksXYFieldGenerator))]
[Register(typeof(CharFieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(Array2dFieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(FolderPerRecordGroupFieldGenerator), typeof(ISerializationForFieldGenerator), typeof(FolderPerRecordGroupFieldGenerator))]
[Register(typeof(CacheFieldGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(EdidLinkGenerator), typeof(ISerializationForFieldGenerator))]
[Register(typeof(FolderForSingleLoquiFieldGenerator), typeof(ISerializationForFieldGenerator))]
partial class SerializationSourceGeneratorContainer : IContainer<SerializationSourceGeneratorInitializer>
{
}