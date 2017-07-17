using System;
using System.Text.RegularExpressions;

namespace P7_ValidTime
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                Regex regex = new Regex("^((([0][0-9]|[1][0-1]):[0-5][0-9]:[0-5][0-9] [AP]M)|12:00:00 [PA]M)$");
                Match match = regex.Match(input);
                if (match.Success)
                {

                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
                input = Console.ReadLine();
            }
        }
    }
}
