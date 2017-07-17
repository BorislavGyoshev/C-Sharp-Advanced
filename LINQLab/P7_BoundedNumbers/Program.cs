using System;
using System.Linq;

namespace P7_BoundedNumbers
{
    class Program
    {
        static void Main()
        {
            int[] bound = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).Where(n => n >= bound.Min() && n <= bound.Max()).ToArray();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
