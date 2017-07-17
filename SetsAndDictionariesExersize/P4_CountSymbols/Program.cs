﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace P4_CountSymbols
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> dict = new SortedDictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (dict.Keys.Contains(input[i]))
                {
                    dict[input[i]]++;
                }
                else
                {
                    dict.Add(input[i], 1);
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
