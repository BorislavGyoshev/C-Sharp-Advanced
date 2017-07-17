using System;
using System.Text.RegularExpressions;

namespace P8_ExtractQuotations
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Regex pattern = new Regex("('|\")(.+?)\\1");
            MatchCollection matches = pattern.Matches(input);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[2].Value);
            }
        }
    }
}
