using System;
using System.Linq;

namespace P2_SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(input.Count());
            Console.WriteLine(input.Select(int.Parse).Sum());
        }
    }
}
