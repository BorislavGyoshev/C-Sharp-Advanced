using System;
using System.Text.RegularExpressions;

namespace P2_MatchPhoneNumber
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                Regex pattern = new Regex(@"\+359([ |-])2\1[\d]{3}\1[\d]{4}\b");
                Match match = pattern.Match(input);
                if (match.Success)
                {
                    Console.WriteLine(match);
                }
                input = Console.ReadLine();
            }
        }
    }
}
