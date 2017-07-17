using System;
using System.Collections.Generic;
using System.Linq;

namespace MatchingBrackets
{
    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < input.Count(); i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i.ToString());
                }
                if (input[i] == ')')
                {
                    for (int j = int.Parse(stack.Pop()); j <= i; j++)
                    {
                        Console.Write(input[j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
