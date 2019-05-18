using System;
using System.Collections.Generic;

namespace MySolution.MyLibrary
{
    public class StringService : IStringService
    {
        public PalindromeResult[] FindPalindromes(string text, bool includeSubstrings)
        {
            text = (text ?? string.Empty);//.Trim();

            // results will be ordered by palindrome subString length (descending) and then by palindrome subString index
            // (same palindrome subString could be in the text multiple times with different indexes)
            var list = new SortedList<int, SortedList<int, string>>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            int lastIndex = 1;
            for (int i = 0; i < text.Length - 1; i++)
            {
                for (int j = text.Length; j >= lastIndex; j--)
                {
                    int length = j - i;
                    if (length > 1)
                    {
                        if (text[j - 1] == text[i])
                        {
                            string currentText = text.Substring(i, length);
                            if (IsPalindrome(currentText))
                            {
                                SortedList<int, string> temp;
                                if (!list.TryGetValue(length, out temp))
                                {
                                    temp = new SortedList<int, string>();
                                    list.Add(length, temp);
                                }
                                temp.Add(i, currentText);
                                if (!includeSubstrings)
                                {
                                    lastIndex = i + length + 1;
                                    break;
                                }
                            }
                        }
                    }
                }                
            }

            var results = new List<PalindromeResult>();
            foreach (var item in list)
            {
                foreach (var subList in item.Value)
                {
                    results.Add(new PalindromeResult() { Length = item.Key, Index = subList.Key, Text = subList.Value });
                }
            }
            return results.ToArray();
        }
        
        public bool IsPalindrome(string text)
        {
            text = (text ?? string.Empty).Trim();

            if (text.Length > 1)
            {
                int index = 0;
                while (index < text.Length / 2)
                {
                    if (text[index] == text[text.Length - index - 1])
                    {
                        index++;
                    }
                    else
                    {
                        return false;
                    }
                }

                return true;
            }

            return false;
        }
    }
}
