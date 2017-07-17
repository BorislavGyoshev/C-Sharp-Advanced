using System;
using System.Collections.Generic;

namespace P5_Phonebook
{
    class Starup
    {
        static void Main()
        {
            SortedDictionary<string, string> fonebook = new SortedDictionary<string, string>();
            string[] input = Console.ReadLine().Split('-');
            while (input[0] != "search")
            {
                if (input.Length > 1)
                {
                    if (fonebook.ContainsKey(input[0]))
                    {
                        fonebook[input[0]] = input[1];
                    }
                    else
                    {
                        fonebook.Add(input[0], input[1]);
                    }
                }
                input = Console.ReadLine().Split('-');
            }
            input = Console.ReadLine().Split('-');
            while (input[0] != "stop")
            {
                if (fonebook.ContainsKey(input[0]))
                {
                    Console.WriteLine($"{input[0]} -> {fonebook[input[0]]}");
                }
                else
                {
                    Console.WriteLine($"Contact {input[0]} does not exist.");
                }
                input = Console.ReadLine().Split('-');
            }
        }
    }
}
