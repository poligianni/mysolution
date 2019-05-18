using System.Collections;
using System.Collections.Generic;

namespace MySolution.MyLibrary.Test
{
    public class StringServiceTestsData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { null, new PalindromeResult[] { } };
            yield return new object[] { "", new PalindromeResult[] { } };
            yield return new object[] { "A", new PalindromeResult[] { } };
            yield return new object[] { "AB", new PalindromeResult[] { } };
            yield return new object[] { "AA", new PalindromeResult[] { new PalindromeResult { Length = 2, Index = 0, Text = "AA" } } };
            yield return new object[] { "ABA", new PalindromeResult[] { new PalindromeResult { Length = 3, Index = 0, Text = "ABA" } } };
            yield return new object[] { "ABC", new PalindromeResult[] { } };
            yield return new object[] { "AAB", new PalindromeResult[] { new PalindromeResult { Length = 2, Index = 0, Text = "AA" } } };
            yield return new object[] { "AABB", new PalindromeResult[] { new PalindromeResult { Length = 2, Index = 0, Text = "AA" }, new PalindromeResult { Length = 2, Index = 2, Text = "BB" } } };
            yield return new object[] { "ABAB", new PalindromeResult[] { new PalindromeResult { Length = 3, Index = 0, Text = "ABA" }, new PalindromeResult { Length = 3, Index = 1, Text = "BAB" } } };
            yield return new object[] { "ABBA", new PalindromeResult[] { new PalindromeResult { Length = 4, Index = 0, Text = "ABBA" }, new PalindromeResult { Length = 2, Index = 1, Text = "BB" } } };
            yield return new object[] { "ABCBA", new PalindromeResult[] { new PalindromeResult { Length = 5, Index = 0, Text = "ABCBA" }, new PalindromeResult { Length = 3, Index = 1, Text = "BCB" } } };
            yield return new object[] { "ABBBA", new PalindromeResult[] { new PalindromeResult { Length = 5, Index = 0, Text = "ABBBA" }, new PalindromeResult { Length = 3, Index = 1, Text = "BBB" }, new PalindromeResult { Length = 2, Index = 1, Text = "BB" }, new PalindromeResult { Length = 2, Index = 2, Text = "BB" } } };
            yield return new object[] { "BBBAC", new PalindromeResult[] { new PalindromeResult { Length = 3, Index = 0, Text = "BBB" }, new PalindromeResult { Length = 2, Index = 0, Text = "BB" }, new PalindromeResult { Length = 2, Index = 1, Text = "BB" } } };
            yield return new object[] { "ABCBABCBD", new PalindromeResult[] { new PalindromeResult { Length = 7, Index = 1, Text = "BCBABCB" }, new PalindromeResult { Length = 5, Index = 0, Text = "ABCBA" }, new PalindromeResult { Length = 5, Index = 2, Text = "CBABC" }, new PalindromeResult { Length = 3, Index = 1, Text = "BCB" }, new PalindromeResult { Length = 3, Index = 3, Text = "BAB" }, new PalindromeResult { Length = 3, Index = 5, Text = "BCB" } } };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public class StringServiceTestsData2 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { null, new PalindromeResult[] { } };
            yield return new object[] { "", new PalindromeResult[] { } };
            yield return new object[] { "A", new PalindromeResult[] { } };
            yield return new object[] { "AB", new PalindromeResult[] { } };
            yield return new object[] { "AA", new PalindromeResult[] { new PalindromeResult { Length = 2, Index = 0, Text = "AA" } } };
            yield return new object[] { "ABA", new PalindromeResult[] { new PalindromeResult { Length = 3, Index = 0, Text = "ABA" } } };
            yield return new object[] { "ABC", new PalindromeResult[] { } };
            yield return new object[] { "AAB", new PalindromeResult[] { new PalindromeResult { Length = 2, Index = 0, Text = "AA" } } };
            yield return new object[] { "AABB", new PalindromeResult[] { new PalindromeResult { Length = 2, Index = 0, Text = "AA" }, new PalindromeResult { Length = 2, Index = 2, Text = "BB" } } };
            yield return new object[] { "ABAB", new PalindromeResult[] { new PalindromeResult { Length = 3, Index = 0, Text = "ABA" }, new PalindromeResult { Length = 3, Index = 1, Text = "BAB" } } };
            yield return new object[] { "ABBA", new PalindromeResult[] { new PalindromeResult { Length = 4, Index = 0, Text = "ABBA" } } };
            yield return new object[] { "ABCBA", new PalindromeResult[] { new PalindromeResult { Length = 5, Index = 0, Text = "ABCBA" } } };
            yield return new object[] { "ABBBA", new PalindromeResult[] { new PalindromeResult { Length = 5, Index = 0, Text = "ABBBA" } } };
            yield return new object[] { "BBBAC", new PalindromeResult[] { new PalindromeResult { Length = 3, Index = 0, Text = "BBB" } } };
            yield return new object[] { "ABCBABCBD", new PalindromeResult[] { new PalindromeResult { Length = 7, Index = 1, Text = "BCBABCB" }, new PalindromeResult { Length = 5, Index = 0, Text = "ABCBA" }  } };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}