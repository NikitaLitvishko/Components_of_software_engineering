using Xunit;
using IIG.PasswordHashingUtils;
using System;

public class TestClass
{
    public void ResetPasswordHasher()
    {
        PasswordHasher.Init("put your soul(or salt) here", 65521);
    }

    // 0_2_3_4_5

    [Fact]
    public void ExecutionRoute_0_2_3_4_5_EverythingIsOK_CheckSameValues()
    {
        string pass = "passwordForLab3";
        string exp = PasswordHasher.GetHash(pass);

        Assert.Equal(exp, PasswordHasher.GetHash(pass));

        ResetPasswordHasher();
    }

    [Fact]
    public void ExecutionRoute_0_2_3_4_5_EverythingIsOK()
    {
        try
        {
            PasswordHasher.Init("Salt_number_1", 1);

            Assert.True(true);
        }
        catch (Exception)
        {
            Assert.False(true);
        }
        finally
        {
            ResetPasswordHasher();
        }
    }

    [Fact]
    public void ExecutionRoute_0_2_3_4_5_EverythingIsOK_CheckDifferentValues()
    {
        string pass = "passwordForLab3";
        string exp = PasswordHasher.GetHash(pass);

        PasswordHasher.Init("Salt_number_1", 1);

        Assert.NotEqual(exp, PasswordHasher.GetHash(pass));

        ResetPasswordHasher();
    }

    // 0_1_2_3_4_5

    [Fact]
    public void ExecutionRoute_0_1_2_3_4_5_CatchException_CheckDifferentValues()
    {
        string pass = "لْعَرَبِيَّةُ";
        string exp = PasswordHasher.GetHash(pass);

        PasswordHasher.Init("Salt_number_1", 1);

        Assert.NotEqual(exp, PasswordHasher.GetHash(pass));

        ResetPasswordHasher();
    }

    // 0_3_5

    [Fact]
    public void ExecutionRoute_0_3_5_AllSkipped_CheckSameValues()
    {
        string pass = "passwordForLab3";
        string exp = PasswordHasher.GetHash(pass);

        PasswordHasher.Init("", 0);

        Assert.Equal(exp, PasswordHasher.GetHash(pass));

        PasswordHasher.Init(null, 0);

        Assert.Equal(exp, PasswordHasher.GetHash(pass));

        ResetPasswordHasher();
    }

    // 
}
