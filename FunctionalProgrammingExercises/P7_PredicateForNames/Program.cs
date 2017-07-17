using System;
using System.Linq;

namespace P7_PredicateForNames
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            names.Where(w => w.Length <= n).ToList().ForEach(w => Console.WriteLine(w));
            Console.WriteLine();
        }
    }
}
