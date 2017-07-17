using System;

namespace P2_KnightsOfHonor
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            Action<string> print = n => Console.WriteLine($"Sir {n}");
            foreach (var name in input)
            {
                print(name);
            }
        }
    }
}
