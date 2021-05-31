using Xunit;
using IIG.BinaryFlag;
using System;

public class TestClass
{
    // Constructor Tests

    ulong minValue = 2;
    ulong maxValue = 17179868704;

    [Fact]
    public void Constructor_zeroTrue_Exception()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(minValue - 2, true));
    }

    [Fact]
    public void Constructor_oneTrue_Exception()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(minValue - 1, true));
    }

    [Fact]
    public void Constructor_zeroFalse_Exception()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(minValue - 2, false));
    }

    [Fact]
    public void Constructor_oneFalse_Exception()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(minValue - 1, false));
    }

    [Fact]
    public void Constructor_moreThanOneTrue_NotNull()
    {
        MultipleBinaryFlag flag =  new MultipleBinaryFlag(4, true);

        Assert.NotNull(flag);
    }

    [Fact]
    public void Constructor_maxValueForConstructorTrue_NotNull()
    {
        MultipleBinaryFlag flag =  new MultipleBinaryFlag(maxValue, true);

        Assert.NotNull(flag);
    }

    [Fact]
    public void Constructor_maxValueForConstructorFalse_NotNull()
    {
        MultipleBinaryFlag flag =  new MultipleBinaryFlag(maxValue, false);

        Assert.NotNull(flag);
    }

    [Fact]
    public void Constructor_maxValueForConstructorNothing_NotNull()
    {
        MultipleBinaryFlag flag =  new MultipleBinaryFlag(maxValue);

        Assert.NotNull(flag);
    }

    [Fact]
    public void Constructor_moreThanMaxValueForConstructorTrue_NotNull()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(maxValue + 1, true));
    }

    [Fact]
    public void Constructor_moreThanMaxValueForConstructorFalse_NotNull()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(maxValue + 1, false));
    }

    [Fact]
    public void Constructor_moreThanMaxValueForConstructorNothing_NotNull()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(maxValue + 1));
    }

    [Fact]
    public void Constructor_lessThanMaxValueForConstructorTrue_NotNull()
    {
        MultipleBinaryFlag flag =  new MultipleBinaryFlag(maxValue - 1, true);

        Assert.NotNull(flag);
    }

    [Fact]
    public void Constructor_lessThanMaxValueForConstructorFalse_NotNull()
    {
        MultipleBinaryFlag flag =  new MultipleBinaryFlag(maxValue - 1, false);

        Assert.NotNull(flag);
    }

    [Fact]
    public void Constructor_lessThanMaxValueForConstructorNothing_NotNull()
    {
        MultipleBinaryFlag flag =  new MultipleBinaryFlag(maxValue - 1);

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
    public void Constructor_lessThanMaxUlongNothing_Exception()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(ulong.MaxValue - 1));
    }

    [Fact]
    public void Constructor_lessThanMaxUlongTrue_Exception()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(ulong.MaxValue - 1, true));
    }

    [Fact]
    public void Constructor_lessThanMaxUlongFalse_Exception()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(ulong.MaxValue - 1, false));
    }

    [Fact]
    public void Constructor_moreThanOneTrue_True()
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

    [Fact]
    public void Constructor_TrueException_minUlong()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(ulong.MinValue, true));
    }

    [Fact]
    public void Constructor_TrueException_MoreThanMinUlong()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(ulong.MinValue + 1, true));
    }

    [Fact]
    public void Constructor_FalseException_minUlong()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(ulong.MinValue, false));
    }

    [Fact]
    public void Constructor_FalseException_MoreThanMinUlong()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new MultipleBinaryFlag(ulong.MinValue + 1, false));
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
    public void GetFlag_Nothing_TrueEqual_LessThanMaxValue()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(maxValue - 1, true);

        bool? exp = true;

        bool? act = flag.GetFlag();

        Assert.Equal(exp, act);
    }

    [Fact]
    public void GetFlag_Nothing_TrueEqual_MaxValue()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(maxValue, true);

        bool? exp = true;

        bool? act = flag.GetFlag();

        Assert.Equal(exp, act);
    }

    [Fact]
    public void GetFlag_Nothing_FalseNotEqual_LessThanMaxValue()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(maxValue - 1, false);

        bool? exp = true;

        bool? act = flag.GetFlag();

        Assert.NotEqual(exp, act);
    }

    [Fact]
    public void GetFlag_Nothing_FalseNotEqual_MaxValue()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(maxValue, false);

        bool? exp = true;

        bool? act = flag.GetFlag();

        Assert.NotEqual(exp, act);
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

    [Fact]
    public void GetFlag_Nothing_TrueEqual_MoreThanMinValue()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(minValue + 1, true);

        bool? exp = true;

        bool? act = flag.GetFlag();

        Assert.Equal(exp, act);
    }

    [Fact]
    public void GetFlag_Nothing_TrueEqual_MinValue()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(minValue, true);

        bool? exp = true;

        bool? act = flag.GetFlag();

        Assert.Equal(exp, act);
    }

    [Fact]
    public void GetFlag_Nothing_FalseNotEqual_MoreThanMinValue()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(minValue + 1, false);

        bool? exp = true;

        bool? act = flag.GetFlag();

        Assert.NotEqual(exp, act);
    }

    [Fact]
    public void GetFlag_Nothing_FalseNotEqual_MinValue()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(minValue, false);

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

    [Fact]
    public void SetFlag_FalseException_MaxValue()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2, false);

        Assert.Throws<ArgumentOutOfRangeException>(() => flag.SetFlag(maxValue));
    }

    [Fact]
    public void SetFlag_FalseException_MoreThanMaxValue()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2, false);

        Assert.Throws<ArgumentOutOfRangeException>(() => flag.SetFlag(maxValue + 1));
    }

    [Fact]
    public void SetFlag_FalseException_LessThanMaxValue()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2, false);

        Assert.Throws<ArgumentOutOfRangeException>(() => flag.SetFlag(maxValue - 1));
    }

    [Fact]
    public void SetFlag_FalseException_MinValue()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2, false);

        Assert.Throws<ArgumentOutOfRangeException>(() => flag.SetFlag(minValue));
    }

    [Fact]
    public void SetFlag_FalseException_MoreThanMinValue()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2, false);

        Assert.Throws<ArgumentOutOfRangeException>(() => flag.SetFlag(minValue + 1));
    }

    [Fact]
    public void GetFlag_SetFlag_FalseEqual_LessThanMinValue()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2, false);

        bool? exp = flag.GetFlag();

        flag.SetFlag(minValue - 1);

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

    [Fact]
    public void ResetFlag_FalseException_MinValue()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2, false);

        Assert.Throws<ArgumentOutOfRangeException>(() => flag.ResetFlag(minValue));
    }

    [Fact]
    public void GetFlag_ResetFlag_FalseEqual_LessThanMinValue()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2, false);

        bool? exp = flag.GetFlag();

        flag.ResetFlag(minValue - 1);

        bool? act = flag.GetFlag();

        Assert.Equal(exp, act);
    }

    [Fact]
    public void ResetFlag_FalseException_MoreThanMinValue()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2, false);

        Assert.Throws<ArgumentOutOfRangeException>(() => flag.ResetFlag(minValue + 1));
    }

    [Fact]
    public void ResetFlag_FalseException_MaxValue()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2, false);

        Assert.Throws<ArgumentOutOfRangeException>(() => flag.ResetFlag(maxValue));
    }

    [Fact]
    public void ResetFlag_FalseException_LessThanMaxValue()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2, false);

        Assert.Throws<ArgumentOutOfRangeException>(() => flag.ResetFlag(maxValue - 1));
    }

    [Fact]
    public void ResetFlag_FalseException_MoreThanMaxValue()
    {
        MultipleBinaryFlag flag = new MultipleBinaryFlag(2, false);

        Assert.Throws<ArgumentOutOfRangeException>(() => flag.ResetFlag(maxValue + 1));
    }
}
