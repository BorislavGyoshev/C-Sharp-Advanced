using System;
using System.Linq;

namespace P5_AppliedArithmetics
{
    class Program
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            Func<int[], int[]> add = n => n.Select(x => x + 1).ToArray();
            Func<int[], int[]> multiply = n => n.Select(x => x * 2).ToArray();
            Func<int[], int[]> subtract = n => n.Select(x => x - 1).ToArray();
            Action<int[]> print = n => Console.WriteLine(string.Join(" ", n));
            while (command != "end")
            {
                switch (command)
                {
                    case "add": numbers = add.Invoke(numbers); break;
                    case "multiply": numbers = multiply.Invoke(numbers); break;
                    case "subtract": numbers = subtract.Invoke(numbers); break;
                    case "print": print.Invoke(numbers); break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
