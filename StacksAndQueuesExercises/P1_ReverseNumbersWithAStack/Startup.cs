using System;
using System.Collections.Generic;
using System.Text;

namespace P1_ReverseNumbersWithAStack
{
    class Startup
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            var stack = new Stack<string>(input);
            StringBuilder result = new StringBuilder();
            foreach (var num in stack)
            {
                result.Append(num + " ");
            }
            Console.WriteLine(result);
        }
    }
}
