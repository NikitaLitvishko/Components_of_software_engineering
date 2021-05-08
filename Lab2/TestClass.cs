using Xunit;
using IIG.BinaryFlag;
using System;

public class TestClass
{
    // Constructor Tests

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

    [Fact]
    public void Constructor_moreThanOneTrue_NotNull()
    {
        MultipleBinaryFlag flag =  new MultipleBinaryFlag(4, true);

        Assert.NotNull(flag);
    }

    [Fact]
    public void Constructor_moreThanOneFalse_NotNull()
    {
        MultipleBinaryFlag flag =  new MultipleBinaryFlag(4, false);

        Assert.NotNull(flag);
    }

    [Fact]
    public void Constructor_moreThanOneNothing_NotNull()
    {
        MultipleBinaryFlag flag =  new MultipleBinaryFlag(4);

        Assert.NotNull(flag);
    }

    [Fact]
    public void Constructor_maxUlongNothing_Exception()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(ulong.MaxValue));
    }

    [Fact]
    public void Constructor_maxUlongTrue_Exception()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(ulong.MaxValue, true));
    }

    [Fact]
    public void Constructor_maxUlongFalse_Exception()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(ulong.MaxValue, false));
    }

    [Fact]
    public void Constructor_moreThanOneFalse_True()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2, true);

        Assert.True(flag.GetFlag());
    }

    [Fact]
    public void Constructor_moreThanOneFalse_False()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2, false);

        Assert.False(flag.GetFlag());
    }

    [Fact]
    public void Constructor_moreThanOneNothing_True()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2);

        Assert.True(flag.GetFlag());
    }

    // Dispose Tests

    [Fact]
    public void Dispose_Nothing_Null()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2, false);

        flag.Dispose();

        Assert.Null(flag.GetFlag());
    }

    [Fact]
    public void Dispose_Nothing_NotEqual()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2, false);
        bool? exp = flag.GetFlag();

        flag.Dispose();

        bool? act = flag.GetFlag();

        Assert.NotEqual(exp, act);
    }

    // GetFlag Tests

    [Fact]
    public void GetFlag_Nothing_TrueEqual()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(5, true);

        bool? exp = true;

        bool? act = flag.GetFlag();

        Assert.Equal(exp, act);
    }

    [Fact]
    public void GetFlag_Nothing_FalseEqual()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(5, false);

        bool? exp = false;

        bool? act = flag.GetFlag();

        Assert.Equal(exp, act);
    }

    [Fact]
    public void GetFlag_Nothing_TrueNotEqual()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(5, true);

        bool? exp = false;

        bool? act = flag.GetFlag();

        Assert.NotEqual(exp, act);
    }

    [Fact]
    public void GetFlag_Nothing_FalseNotEqual()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(5, false);

        bool? exp = true;

        bool? act = flag.GetFlag();

        Assert.NotEqual(exp, act);
    }

    // GetFlag / SetFlag Tests

    [Fact]
    public void GetFlag_SetFlag_FalseEqual()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2, false);

        bool? exp = flag.GetFlag();

        flag.SetFlag(0);

        bool? act = flag.GetFlag();

        Assert.Equal(exp, act);
    }

    [Fact]
    public void GetFlag_SetFlag_FalseNotEqual()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2, false);

        bool? exp = flag.GetFlag();

        flag.SetFlag(0);
        flag.SetFlag(1);

        bool? act = flag.GetFlag();

        Assert.NotEqual(exp, act);
    }

    [Fact]
    public void GetFlag_SetFlag_TrueEqual()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2, true);

        bool? exp = flag.GetFlag();

        flag.SetFlag(0);

        bool? act = flag.GetFlag();

        Assert.Equal(exp, act);
    }

    [Fact]
    public void GetFlag_SetFlag_NothingEqual()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2);

        bool? exp = flag.GetFlag();

        flag.SetFlag(0);

        bool? act = flag.GetFlag();

        Assert.Equal(exp, act);
    }

    // GetFlag / ResetFlag Tests

    [Fact]
    public void GetFlag_ResetFlag_FalseEqual()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2, false);

        bool? exp = flag.GetFlag();

        flag.ResetFlag(0);

        bool? act = flag.GetFlag();

        Assert.Equal(exp, act);
    }

    [Fact]
    public void GetFlag_ResetFlag_TrueNotEqual()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2, true);

        bool? exp = flag.GetFlag();

        flag.ResetFlag(0);

        bool? act = flag.GetFlag();

        Assert.NotEqual(exp, act);
    }

    [Fact]
    public void GetFlag_ResetFlag_TrueEqual()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2, true);

        bool? exp = flag.GetFlag();

        flag.ResetFlag(0);
        flag.ResetFlag(1);

        bool? act = flag.GetFlag();

        Assert.NotEqual(exp, act);
    }

    [Fact]
    public void GetFlag_ResetFlag_NothingNotEqual()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2);

        bool? exp = flag.GetFlag();

        flag.ResetFlag(0);

        bool? act = flag.GetFlag();

        Assert.NotEqual(exp, act);
    }

    [Fact]
    public void GetFlag_ResetFlag_NothingEqual()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2);

        bool? exp = flag.GetFlag();

        flag.ResetFlag(0);
        flag.ResetFlag(1);

        bool? act = flag.GetFlag();

        Assert.NotEqual(exp, act);
    }
}
