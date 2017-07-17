using System;
using System.Text.RegularExpressions;

namespace P4_ExtractIntegerNumbers
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Regex regex = new Regex("\\d+");
            MatchCollection matches = regex.Matches(input);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
