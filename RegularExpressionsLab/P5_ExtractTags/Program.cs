using System;
using System.Text.RegularExpressions;

namespace P5_ExtractTags
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                Regex regex = new Regex("<.+?>");
                MatchCollection matches = regex.Matches(input);
                foreach (var match in matches)
                {
                    Console.WriteLine(match);
                }
                input = Console.ReadLine();
            }
        }
    }
}
