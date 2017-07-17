using System;
using System.Text.RegularExpressions;

namespace P3_SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = Regex.Replace(input, @"([a-zA-Z])\1+", c => c.Groups[1].ToString());
            Console.WriteLine(result);
        }
    }
}
