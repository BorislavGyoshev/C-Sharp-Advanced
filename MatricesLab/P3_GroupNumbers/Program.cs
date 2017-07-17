using System;
using System.Collections.Generic;
using System.Linq;

namespace P3_GroupNumbers
{
    class Program
    {
        static void Main()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            int[] numbers = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            List<int> list0 = new List<int>();
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            string result = string.Empty;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    list0.Add(numbers[i]);
                }
                else if (numbers[i] % 3 == 1 || numbers[i] % 3 == -1)
                {
                    list1.Add(numbers[i]);
                }
                else if (numbers[i] % 3 == 2 || numbers[i] % 3 == -2)
                {
                    list2.Add(numbers[i]);
                }
            }

            foreach (var item in list0)
            {
                result += item + " ";
            }
            Console.WriteLine(result.Trim());
            result = string.Empty;
            foreach (var item in list1)
            {
                result += item + " ";
            }
            Console.WriteLine(result.Trim());
            result = string.Empty;
            foreach (var item in list2)
            {
                result += item + " ";
            }
            Console.WriteLine(result.Trim());
            watch.Stop();
            Console.WriteLine(watch.ElapsedTicks);
        }
    }
}
