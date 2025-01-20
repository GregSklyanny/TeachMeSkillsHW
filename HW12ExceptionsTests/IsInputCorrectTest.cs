using HWExceptions;
namespace HW12ExceptionsTests
{
    public class IsInputCorrectTest
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

    }
}