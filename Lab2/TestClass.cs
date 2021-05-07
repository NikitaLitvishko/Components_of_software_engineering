using Xunit;
using IIG.BinaryFlag;
using System;

public class TestClass
{
    [Fact]
    public void Constructor_zeroTrue_Exception()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(0, true));
    }

    [Fact]
    public void Constructor_oneTrue_Exception()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(1, true));
    }

    [Fact]
    public void Constructor_zeroFalse_Exception()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(0, false));
    }

    [Fact]
    public void Constructor_oneFalse_Exception()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(1, false));
    }
}