using System;
using System.Linq;

namespace P4_AverageOfDoubles
{
    class Program
    {
        static void Main()
        {
            double number = Console.ReadLine().Split().Select(double.Parse).Average();
            Console.WriteLine($"{number:f2}");
        }
    }
}
