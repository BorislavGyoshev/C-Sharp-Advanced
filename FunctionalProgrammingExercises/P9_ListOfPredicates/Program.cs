using System;
using System.Linq;

namespace P9_ListOfPredicates
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            bool isTrue = false;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i % numbers[j] != 0)
                    {
                        isTrue = false;
                        break;
                    }
                    isTrue = true;
                }
                if (isTrue == true)
                {
                    Console.Write($"{i} ");
                    isTrue = false;
                }
            }
            Console.WriteLine();
        }
    }
}
