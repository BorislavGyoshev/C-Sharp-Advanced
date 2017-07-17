using System;
using System.Text.RegularExpressions;

namespace P3_NonDigitCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex("[\\D]");
            MatchCollection match = regex.Matches(input);
            Console.WriteLine($"Non-digits: {match.Count}");
        }
    }
}
