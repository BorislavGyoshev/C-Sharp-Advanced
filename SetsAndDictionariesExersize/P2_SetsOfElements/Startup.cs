using System;
using System.Collections.Generic;
using System.Linq;

namespace P2_SetsOfElements
{
    class Startup
    {
        static void Main()
        {
            int[] nm = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            SortedDictionary<int, int> dict = new SortedDictionary<int, int>();
            for (int i = 0; i < nm[0]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                dict.Add(num, 1);
            }
            for (int i = 0; i < nm[1]; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (dict.Keys.Contains(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict.Add(num, 1);
                }
            }
            foreach (var num in dict)
            {
                if (num.Value > 1)
                {
                    Console.Write($"{num.Key} ");
                }
            }
        }
    }
}
