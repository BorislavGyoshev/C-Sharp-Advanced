using System;
using System.Linq;

namespace P8_CustomComparator
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            numbers.Where(n => n % 2 == 0).OrderBy(n => n).ToList().ForEach(n => Console.Write($"{n} "));
            numbers.Where(n => n % 2 != 0).OrderBy(n => n).ToList().ForEach(n => Console.Write($"{n} "));
            Console.WriteLine();
        }
    }
}
