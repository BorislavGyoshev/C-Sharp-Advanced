using System;
using System.Linq;

namespace P3_CustomMinFunction
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            Func<int[], int> print = d => d.Min();
            Console.WriteLine(print(input.Select(int.Parse).ToArray()));
        }
    }
}
