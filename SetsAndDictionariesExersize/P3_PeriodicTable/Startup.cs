using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_PeriodicTable
{
    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> compounds = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' });
                for (int j = 0; j < input.Length; j++)
                {
                    compounds.Add(input[j]);
                }
            }
            foreach (var compound in compounds)
            {
                Console.Write($"{compound} ");
            }
        }
    }
}
