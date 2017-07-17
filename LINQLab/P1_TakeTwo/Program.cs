using System;
using System.Linq;

namespace P1_TakeTwo
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Distinct().Where(n => n > 9 && n < 21).Take(2).ToArray();
            //for (int i = 0; i < 2 && i < numbers.Length; i++)
            //{
            //    Console.Write($"{numbers[i]} ");
            //}
            foreach (var num in numbers)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
