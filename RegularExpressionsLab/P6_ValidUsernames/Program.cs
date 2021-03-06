﻿using System;
using System.Text.RegularExpressions;

namespace P6_ValidUsernames
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                Regex regex = new Regex("^[\\w-]{3,16}$");
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
