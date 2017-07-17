using System;
using System.Collections.Generic;
using System.Linq;

namespace P11_LogsAggregator
{
    class Program
    {
        static void Main()
        {
            SortedDictionary<string, SortedDictionary<string, long>> dict = new SortedDictionary<string, SortedDictionary<string, long>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[1];
                string ip = input[0];
                long duration = long.Parse(input[2]);
                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, new SortedDictionary<string, long>());
                    dict[name].Add(ip, duration);
                }
                else
                {
                    if (!dict[name].ContainsKey(ip))
                    {
                        dict[name].Add(ip, duration);
                    }
                    else
                    {
                        dict[name][ip] += duration;
                    }
                }
            }

            foreach (var name in dict)
            {
                Console.Write($"{name.Key}: {name.Value.Values.Sum()} [");
                int tmp = 0;
                foreach (var ip in name.Value)
                {
                    if (tmp == 0)
                    {
                        Console.Write($"{ip.Key}");
                    }
                    else
                    {
                        Console.Write($", {ip.Key}");
                    }
                    tmp++;
                }
                Console.WriteLine("]");
                tmp = 0;
            }
        }
    }
}