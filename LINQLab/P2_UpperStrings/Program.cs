using System;
using System.Collections.Generic;
using System.Linq;

namespace P2_UpperStrings
{
    class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split().Select(w => w.ToUpper()).ToList();
            input.ForEach(w => Console.Write($"{w} "));
        }
    }
}
