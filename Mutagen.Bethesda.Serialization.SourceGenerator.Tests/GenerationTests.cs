﻿namespace Mutagen.Bethesda.Serialization.Tests.SourceGenerators;

[UsesVerify]
public class GenerationTests
{
    [Fact]
    public Task NoGeneration()
    {
        var source = @"
using Mutagen.Bethesda.Serialization.Newtonsoft;

public class BasicPassthroughs
{
    [Fact]
    public void BasicPassthrough()
    {
    }
}";
       
        return TestHelper.Verify(source);
    }
    
    [Fact]
    public Task GeneratesStubForPeriod()
    {
        var source = @"
using Mutagen.Bethesda.Serialization.Newtonsoft;

public class BasicPassthroughs
{
    [Fact]
    public void BasicPassthrough()
    {
        MutagenJsonConverter.
    }
}";
       
        return TestHelper.Verify(source);
    }
    
    [Fact]
    public Task GeneratesStubForYaml()
    {
        var source = @"
using Mutagen.Bethesda.Serialization.Yaml;

public class BasicPassthroughs
{
    [Fact]
    public void BasicPassthrough()
    {
        MutagenYamlConverter.
    }
}";
       
        return TestHelper.Verify(source);
    }
    
    [Fact]
    public Task GeneratesStubForUnknownFunction()
    {
        var source = @"
using Mutagen.Bethesda.Serialization.Newtonsoft;

public class BasicPassthroughs
{
    [Fact]
    public void BasicPassthrough()
    {
        MutagenJsonConverter.Unknown
    }
}";
       
        return TestHelper.Verify(source);
    }
    
    [Fact]
    public Task GeneratesStubForUnknownParameter()
    {
        var source = @"
using Mutagen.Bethesda.Serialization.Newtonsoft;

public class BasicPassthroughs
{
    [Fact]
    public void BasicPassthrough()
    {
        string someVariable = null!;
        MutagenJsonConverter.Convert(someVariable);
    }
}";
       
        return TestHelper.Verify(source);
    }
    
    [Fact]
    public Task GeneratesMultipleStubs()
    {
        var source = @"
using Mutagen.Bethesda.Serialization.Newtonsoft;
using Mutagen.Bethesda.Serialization.Yaml;

public class BasicPassthroughs
{
    [Fact]
    public void BasicPassthrough()
    {
        MutagenJsonConverter.
    }

    [Fact]
    public void BasicPassthrough2()
    {
        MutagenYamlConverter.
    }
}";
       
        return TestHelper.Verify(source);
    }
}