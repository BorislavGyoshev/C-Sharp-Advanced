using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TestingTime
{
    class Program
    {
        static void Main()
        {
            var watch = Stopwatch.StartNew();
            var list = new List<string>();
            for (int i = 0; i < 10000000; i++)
            {
                list.Add(i.ToString());
            }
            watch.Stop();
            Console.WriteLine("Add: " + watch.ElapsedMilliseconds);

            watch = Stopwatch.StartNew();
            list.Contains("888888");
            watch.Stop();
            Console.WriteLine("Contains: " + watch.ElapsedMilliseconds);
        }
    }
}
