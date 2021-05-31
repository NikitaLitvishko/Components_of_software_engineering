using Xunit;
using IIG.PasswordHashingUtils;
using System;

public class TestClass
{
    string defSalt = "put your soul(or salt) here";
    uint defAdler = 65521;

    public void ResetPasswordHasher()
    {
        PasswordHasher.Init(defSalt, defAdler);
    }

    [Fact]
    public void CheckIfHasChanges()
    {
        string pass = "passwordForLab3";

        string exp = PasswordHasher.GetHash(pass);

        Assert.Equal(exp, PasswordHasher.GetHash(pass));
    }

    // Init

    // 0_2_3_4_5

    [Fact]
    public void Init_ExecutionRoute_0_2_3_4_5_EverythingIsOK()
    {
        try
        {
            ResetPasswordHasher();

            PasswordHasher.Init("Salt_number_1", 1);

            Assert.True(true);
        }
        catch (Exception)
        {
            Assert.False(true);
        }
    }

    [Fact]
    public void Init_ExecutionRoute_0_2_3_4_5_CheckDifferentValues()
    {
        ResetPasswordHasher();

        string pass = "passwordForLab3";
        string exp = PasswordHasher.GetHash(pass);

        PasswordHasher.Init("Salt_number_1", 1);

        Assert.NotEqual(exp, PasswordHasher.GetHash(pass));
    }

    // 0_1_2_3_4_5

    [Fact]
    public void Init_ExecutionRoute_0_1_2_3_4_5_CheckDifferentValues()
    {
        ResetPasswordHasher();

        string pass = "passwordForLab3";
        string exp = PasswordHasher.GetHash(pass);

        PasswordHasher.Init("عَرَبِيّ‎", 1);

        Assert.NotEqual(exp, PasswordHasher.GetHash(pass));
    }

    // 0_3_5

    [Fact]
    public void Init_ExecutionRoute_0_3_5_CheckSameValuesWithEmptyAndZero()
    {
        ResetPasswordHasher();

        string pass = "passwordForLab3";
        string exp = PasswordHasher.GetHash(pass);

        PasswordHasher.Init("", 0);

        Assert.Equal(exp, PasswordHasher.GetHash(pass));
    }

    [Fact]
    public void Init_ExecutionRoute_0_3_5_CheckSameValuesWithNullAndZero()
    {
        ResetPasswordHasher();

        string pass = "passwordForLab3";
        string exp = PasswordHasher.GetHash(pass);

        PasswordHasher.Init(null, 0);

        Assert.Equal(exp, PasswordHasher.GetHash(pass));
    }

    // 0_3_4_5

    [Fact]
    public void Init_ExecutionRoute_0_3_4_5_CheckDifferentValuesWithEmptyAndAboveMin()
    {
        ResetPasswordHasher();

        string pass = "passwordForLab3";
        string exp = PasswordHasher.GetHash(pass);

        PasswordHasher.Init("", 2);

        Assert.NotEqual(exp, PasswordHasher.GetHash(pass));
    }

    [Fact]
    public void Init_ExecutionRoute_0_3_4_5_CheckDifferentValuesWithNullAndAboveMin()
    {
        ResetPasswordHasher();

        string pass = "passwordForLab3";
        string exp = PasswordHasher.GetHash(pass);

        PasswordHasher.Init(null, 2);

        Assert.NotEqual(exp, PasswordHasher.GetHash(pass));
    }

    // 0_1_2_3_5

    [Fact]
    public void Init_ExecutionRoute_0_1_2_3_5_CheckDifferentValues()
    {
        ResetPasswordHasher();

        string pass = "passwordForLab3";
        string exp = PasswordHasher.GetHash(pass);

        PasswordHasher.Init("عَرَبِيّ‎", 0);

        Assert.NotEqual(exp, PasswordHasher.GetHash(pass));
    }

    // 0_2_3_5

    [Fact]
    public void Init_ExecutionRoute_0_2_3_5_CheckDifferentValues()
    {
        ResetPasswordHasher();

        string pass = "passwordForLab3";
        string exp = PasswordHasher.GetHash(pass);

        PasswordHasher.Init("Salt_number_1", 1);

        Assert.NotEqual(exp, PasswordHasher.GetHash(pass));
    }

    // GetHash

    // 0_1_4

    [Fact]
    public void GetHash_ExecutionRoute_0_1_4_CheckNullValues()
    {
        ResetPasswordHasher();

        Assert.Null(PasswordHasher.GetHash(null));
    }

    // 0_3_4

    [Fact]
    public void GetHash_ExecutionRoute_0_3_4_CheckOKValues()
    {
        ResetPasswordHasher();

        Assert.NotNull(PasswordHasher.GetHash("passwordForLab3"));
    }

    // 0_3_4

    [Fact]
    public void GetHash_ExecutionRoute_0_2_3_4_CheckExceptionValues()
    {
        ResetPasswordHasher();

        Assert.NotNull(PasswordHasher.GetHash("لْعَرَبِيَّةُ"));
    }

    // Specific call orders

    [Fact]
    public void FullyValid_Init_FullyInvalid_NullAndZero_GetHash()
    {
        string pass = "passwordForLab3";

        PasswordHasher.Init("Salt_number_1", 1);

        string exp = PasswordHasher.GetHash(pass);

        Assert.Equal(exp, PasswordHasher.GetHash(pass, null, 0));
    }

    [Fact]
    public void FullyValid_Init_FullyInvalid_EmptyAndZero_GetHash()
    {
        string pass = "passwordForLab3";

        PasswordHasher.Init("Salt_number_1", 1);

        string exp = PasswordHasher.GetHash(pass);

        Assert.Equal(exp, PasswordHasher.GetHash(pass, "", 0));
    }

    [Fact]
    public void FullyValid_Init_NotFullyValid_NullAndBiggerZero_GetHash()
    {
        string pass = "passwordForLab3";

        PasswordHasher.Init("Salt_number_1", 1);

        string exp = PasswordHasher.GetHash(pass);

        Assert.NotEqual(exp, PasswordHasher.GetHash(pass, null, 2));
    }

    [Fact]
    public void FullyValid_Init_NotFullyValid_EmptyAndBiggerZero_GetHash()
    {
        string pass = "passwordForLab3";

        PasswordHasher.Init("Salt_number_1", 1);

        string exp = PasswordHasher.GetHash(pass);

        Assert.NotEqual(exp, PasswordHasher.GetHash(pass, "", 2));
    }

    [Fact]
    public void NotFullyValid_EmptyAndBiggerZero_Init_FullyValid_GetHash()
    {
        ResetPasswordHasher();

        string pass = "passwordForLab3";

        PasswordHasher.Init("", 1);

        string exp = PasswordHasher.GetHash(pass);

        Assert.NotEqual(exp, PasswordHasher.GetHash(pass, "Salt_number_1", 2));
    }

    [Fact]
    public void NotFullyValid_NullAndBiggerZero_Init_FullyValid_GetHash()
    {
        ResetPasswordHasher();

        string pass = "passwordForLab3";

        PasswordHasher.Init(null, 1);

        string exp = PasswordHasher.GetHash(pass);

        Assert.NotEqual(exp, PasswordHasher.GetHash(pass, "Salt_number_1", 2));
    }

    [Fact]
    public void FullyInvalid_EmptyAndZero_Init_FullyValidGetHash()
    {
        ResetPasswordHasher();

        string pass = "passwordForLab3";

        PasswordHasher.Init("", 0);

        string exp = PasswordHasher.GetHash(pass);

        Assert.NotEqual(exp, PasswordHasher.GetHash(pass, "Salt_number_1", 2));
    }

    [Fact]
    public void FullyInvalid_NullAndZero_Init_FullyValidGetHash()
    {
        ResetPasswordHasher();

        string pass = "passwordForLab3";

        PasswordHasher.Init(null, 0);

        string exp = PasswordHasher.GetHash(pass);

        Assert.NotEqual(exp, PasswordHasher.GetHash(pass, "Salt_number_1", 2));
    }
}
