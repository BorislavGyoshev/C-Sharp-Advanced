using System;
using System.Text.RegularExpressions;

namespace P2_VowelCount
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Regex regex = new Regex("[aeiouyAEIOUY]");
            MatchCollection match = regex.Matches(input);
            Console.WriteLine($"Vowels: {match.Count}");
        }
    }
}
