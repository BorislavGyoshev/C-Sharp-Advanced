using System;
using System.Text.RegularExpressions;

namespace P6_CountSubstringOccurrences
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string searchedString = Console.ReadLine().ToLower();
            var count = Regex.Matches(Regex.Escape(text), searchedString).Count;
            Console.WriteLine(count);
        }
    }
}
