using System;
using System.Collections.Generic;

namespace P9_UserLogs
{
    class Program
    {
        static void Main()
        {
            string str = Console.ReadLine();
            SortedDictionary<string, Dictionary<string, int>> dict = new SortedDictionary<string, Dictionary<string, int>>();
            while (str != "end")
            {
                string[] input = str.Split(new string[] { "IP=", " ", "user=" }, StringSplitOptions.RemoveEmptyEntries);
                if (!dict.ContainsKey(input[2]))
                {
                    dict.Add(input[2], new Dictionary<string, int>());
                    dict[input[2]].Add(input[0], 1);
                }
                else
                {
                    if (!dict[input[2]].ContainsKey(input[0]))
                    {
                        dict[input[2]].Add(input[0], 1);
                    }
                    else
                    {
                        dict[input[2]][input[0]]++;
                    }
                }
                str = Console.ReadLine();
            }
            foreach (var user in dict)
            {
                Console.WriteLine($"{user.Key}:");
                int n = 0;
                foreach (var ip in user.Value)
                {
                    if (n > 0)
                    {
                        Console.Write(", ");
                    }
                    Console.Write($"{ip.Key} => {ip.Value}");
                    n++;
                }
                Console.WriteLine(".");
            }
        }
    }
}
