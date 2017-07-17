using System;
using System.Linq;

namespace P3_CountUppercaseWords
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            input.Where(w => w[0].Equals(w.ToUpper()[0])).ToList().ForEach(w => Console.WriteLine(w));
        }
    }
}
