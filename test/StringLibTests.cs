using Palindrome;
using Xunit;

namespace PalindromeUnitTests
{
    public class StringLibTests
    {
        [Fact]
        public void RemoveSpaces_ShouldRemove()
        {
            var result = StringLib.RemoveSpaces("eleph an t");

            Assert.Equal("elephant", result);
        }

        [Fact]
        public void RemoveSpaces_ShouldNotThrow()
        {
            var result = StringLib.RemoveSpaces(null);

            Assert.Null(result);
        }

        [Theory]
        [InlineData("goog", false, false, true)]
        [InlineData("gooG", false, false, false)]
        [InlineData("gooG", false, true, true)]
        [InlineData("go  og", true, false, true)]
        [InlineData("go  oG", true, false, false)]
        [InlineData("go  oG", true, true, true)]
        public void IsPalindrome_Returns(string s, bool removeSpaces, bool lowerCase, bool expected)
        {
            var result = StringLib.IsPalindrome(s, removeSpaces, lowerCase);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void IsPalindrome_ShouldNotThrow()
        {
            var result = StringLib.IsPalindrome(null, false, false);

            Assert.False(result);
        }
    }
}
