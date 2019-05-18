using System;
using System.Linq;
using Xunit;

namespace MySolution.MyLibrary.Test
{
    public class StringServiceTests 
    {
        private readonly IStringService _stringService;

        public StringServiceTests()
        {
            _stringService = new StringService();
        }

        [Theory]
        [ClassData(typeof(StringServiceTestsData))]
        public void TestFindPalindromesIncludeSubstrings(string text, PalindromeResult[] expected)
        {
            var result = _stringService.FindPalindromes(text, true);
            Assert.NotNull(result);
            Assert.Equal(result.Length, expected.Length);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.Equal(result[i].Length, expected[i].Length);
                Assert.Equal(result[i].Index, expected[i].Index);
                Assert.Equal(result[i].Text, expected[i].Text);
            }
        }

        [Theory]
        [ClassData(typeof(StringServiceTestsData2))]
        public void TestFindPalindromesDoNotIncludeSubstrings(string text, PalindromeResult[] expected)
        {
            var result = _stringService.FindPalindromes(text, false);
            Assert.NotNull(result);
            Assert.Equal(result.Length, expected.Length);
            for (int i = 0; i < result.Length; i++)
            {
                Assert.Equal(result[i].Length, expected[i].Length);
                Assert.Equal(result[i].Index, expected[i].Index);
                Assert.Equal(result[i].Text, expected[i].Text);
            }
        }

        [Theory]
        [InlineData(null, false)]
        [InlineData("", false)]
        [InlineData("1", false)]
        [InlineData("11", true)]
        [InlineData("12", false)]
        [InlineData("111", true)]
        [InlineData("121", true)]
        [InlineData("123", false)]
        [InlineData("1111", true)]
        [InlineData("1221", true)]
        [InlineData("1231", false)]
        [InlineData("1223", false)]
        public void TestIsPalindrome(string text, bool expected)
        {
            var result = _stringService.IsPalindrome(text);
            Assert.Equal(expected, result);
        }
    }
}
