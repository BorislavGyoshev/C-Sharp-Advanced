using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Startup
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int result = 0;
            Stack<string> stack = new Stack<string>(input.Reverse());
            
            while (stack.Count > 1)
            {
                var firstNumber = int.Parse(stack.Pop());
                var op = stack.Pop();
                var secontNumber = int.Parse(stack.Pop());
                if (op == "+")
                {
                    stack.Push((firstNumber + secontNumber).ToString());
                }
                else
                {
                    stack.Push((firstNumber - secontNumber).ToString());
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
