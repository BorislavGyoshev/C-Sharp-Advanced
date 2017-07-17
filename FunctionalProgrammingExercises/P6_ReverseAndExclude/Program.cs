using System;
using System.Linq;

namespace P6_ReverseAndExclude
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int[] result = numbers.Where(nums => nums % n != 0).ToArray();
            for (int i = result.Count() - 1; i >= 0; i--)
            {
                Console.Write($"{result[i]} ");
            }
            Console.WriteLine();
        }
    }
}
