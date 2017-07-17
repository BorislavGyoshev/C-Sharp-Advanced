using System;
using System.Collections.Generic;
using System.Linq;

namespace P3_CountSameValuesInArray
{
    class Startup
    {
        static void Main()
        {
            double[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            SortedDictionary<double, int> dict = new SortedDictionary<double, int>();
            for (int i = 0; i < input.Count(); i++)
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
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
