using System;
using System.Linq;

namespace P4_AddVAT
{
    class Program
    {
        static void Main()
        {
            Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).Select(d => d *= 1.2).ToList().ForEach(n => Console.WriteLine("{0:f}", n));
        }
    }
}
