using MySolution.MyLibrary;
using System;

namespace MySolution.MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IStringService service = new StringService();

            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();
            //string text = "ABCBAHELLOHOWRACECARAREYOUILOVEUEVOLIIAMAIDOINGGOOD";
            //string text = "ABCBABCBD"; => special case, 'overlapping' palindromes => "ABCBA" and "BCBABCB"
            Console.WriteLine();

            Console.WriteLine("Found Palindromes (without Substrings) ");
            var result0 = service.FindPalindromes(text, false);
            Console.WriteLine("Text,Index,Length");
            foreach (var item in result0)
            {
                Console.WriteLine($"{item.Text},{item.Index},{item.Length}");
            }
            Console.WriteLine();

            var result1 = service.FindPalindromes(text, true);
            Console.WriteLine("All Palindromes (including Substrings) ");
            Console.WriteLine("Text,Index,Length");
            foreach (var item in result1)
            {
                Console.WriteLine($"{item.Text},{item.Index},{item.Length}");
            }
            Console.WriteLine();
        }
    }
}
