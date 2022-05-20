
using VerifyPassword;

namespace PasswordTesting
{
    public class PasswordVerifyFixture
    {
        //[Theory]
        //[InlineData("solaris", false)]
        //[InlineData("sol34SOL", true)]

        //public void PasswordTesting(string target,bool expected)
        //{
        //    var actual = Password.Verify(target);

        //    Assert.Equal(expected, actual);
        //}

        //[Fact]

        //public void IsPasswordValid_ValidPassword_ReturnsTrue()
        //{
        //   // Password password = new Password();
        //    String pass= "solaris";
        //    var actual = Password.Verify(pass);
        //    Assert.True(actual);


        //}

        [Theory]
        [InlineData("SolLAHFF556")]
        [InlineData("solaris")]
        [InlineData("SOLARISS")]
        [InlineData("12345678")]
        [InlineData("SoLaRiS2")]
        [InlineData("sol34SOL")]

        public void Password_IsInvalid_ThrowsException(string target)
        {
            //arrange
            Password user = new Password();
            //act and assert

            Assert.Throws<Exception>(() => Password.Verify(target));
            
        }


    }
}