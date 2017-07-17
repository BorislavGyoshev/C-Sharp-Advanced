using System;
using System.Linq;

namespace P5_MinEvenNumber
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("{0:f2}", Console.ReadLine().Split().Select(double.Parse).Where(n => n % 2 == 0).Min());

            }
            catch (Exception e)
            {
                Console.WriteLine("No match");
            }
        }
    }
}
