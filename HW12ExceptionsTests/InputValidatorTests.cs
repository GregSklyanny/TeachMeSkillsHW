using HWExceptions;
namespace HW12ExceptionsTests
{
    public class InputValidatorTests
    {
        [Theory]
        [InlineData("Greg", "112fffa", "112fffa")]
        [InlineData("G", "112fffa", "112fffa")]
        public void CheckValidInput(string login, string password, string passwordConfirmation)
        {
            var result = InputValidator.IsInputCorrect(login, password, passwordConfirmation);
            Assert.True(result);
        }
        [Theory]
        [InlineData("", "112fffa", "112fffa")]
        [InlineData("G", "11d2fffa", "112fffa")]
        [InlineData("Greg", "dddddsssss", "dddddsssss")]
        [InlineData("Greg", "dddddsssssdasdasweqgweg3334343rffaqrfqwefqef", "dddddsssssdasdasweqgweg3334343rffaqrfqwefqef")]
        public void CheckNotValidInput(string login, string password, string passwordConfirmation)
        {
            var result = InputValidator.IsInputCorrect(login, password, passwordConfirmation);
            Assert.False(result);
        }

        [Theory]
        [InlineData("")]
        [InlineData("Greg")]
        [InlineData("adsdqwdqwdqwdqwgwrg545g5ggewgwegwegwerwerwerw3r32r23r23r23r")]
        [InlineData("Gre G")]
        public void CheckLoginValidation_ShouldThrowException(string login)
        {
            Assert.Throws<WrongLoginException>(() => InputValidator.ValidateLogin(login));
        }

        [Theory]
        [InlineData("123","123")]
        [InlineData("1 23", "1 23")]
        [InlineData("12asdasdasdasdasdasdasdqwdqwdqwdqwfgqwfqwfqwfqwfqwf3", "12asdasdasdasdasdasdasdqwdqwdqwdqwfgqwfqwfqwfqwfqwf3")]
        [InlineData("afafssaf", "afafssaf")]
        public void CheckPasswordValidation_ShouldThrowException(string password, string passwordConfirmation)
        {
            Assert.Throws<WrongPasswordException>(() => InputValidator.ValidatePassword(password, passwordConfirmation));
        }

    }
}