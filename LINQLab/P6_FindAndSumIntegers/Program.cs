using System;
using System.Linq;

namespace P6_FindAndSumIntegers
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var sum = input
                .Split()
                .Select(w =>
                {
                    long value;
                    bool success = long.TryParse(w, out value);
                    return new { value, success };
                })
                .Where(s => s.success)
                .Select(n => n.value)
                .ToList()
                .Sum();
            if (sum != 0)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
