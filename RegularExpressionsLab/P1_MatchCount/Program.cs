using System;
using System.Text.RegularExpressions;

namespace P1_MatchCount
{
    class Program
    {
        static void Main()
        {
            string pattern = Console.ReadLine();
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            MatchCollection match = regex.Matches(input);
            Console.WriteLine(match.Count);
        }
    }
}
