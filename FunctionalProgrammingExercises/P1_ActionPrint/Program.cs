using System;

namespace P1_ActionPrint
{
    class Program
    {
        static void Main()
        {

            string[] input = Console.ReadLine().Split(new[] { ' ', '\t' });
            Action<string> print = s => Console.WriteLine(s);
            foreach (var name in input)
            {
                print(name);
            }
        }
    }
}
