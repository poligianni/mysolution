using System.Collections.Generic;

namespace MySolution.MyLibrary
{
    public interface IStringService
    {
        PalindromeResult[] FindPalindromes(string text, bool includeSubstrings);
        bool IsPalindrome(string text);
    }
}