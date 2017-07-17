using System;
using System.Text.RegularExpressions;

namespace P1_MatchFullName
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                Regex regex = new Regex(@"\b[A-Z][a-z]{1,} [A-Z][a-z]{1,}\b");
                Match match = regex.Match(input);
                if (match.Success)
                {
                    Console.WriteLine(match);
                }
                input = Console.ReadLine();
            }
        }
    }
}
