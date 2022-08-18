using Mutagen.Bethesda.Serialization.Newtonsoft;
using Mutagen.Bethesda.Skyrim;
using Xunit;

namespace Mutagen.Bethesda.Serialization.Tests.SerializationTests;

public class SerializationTests
{
    [Fact]
    public void EmptySkyrimMod()
    {
        var mod = new SkyrimMod(Constants.Skyrim, SkyrimRelease.SkyrimSE);
        MutagenJsonConverter.Instance.Convert(mod);
    }
}