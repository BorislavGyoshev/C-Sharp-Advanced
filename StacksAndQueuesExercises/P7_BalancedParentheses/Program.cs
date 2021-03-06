﻿using System;
using System.Collections.Generic;

namespace P7_BalancedParentheses
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char parentheses = input[i];

                switch (parentheses)
                {
                    case '{':
                        stack.Push('{');
                        break;
                    case '[':
                        stack.Push('[');
                        break;
                    case '(':
                        stack.Push('(');
                        break;
                    case '}':
                        if (stack.Count > 0)
                        {
                            char currentSymbol = stack.Pop();
                            if (currentSymbol != '{')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                    case ']':
                        if (stack.Count > 0)
                        {
                            char currentSymbol = stack.Pop();
                            if (currentSymbol != '[')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                    case ')':
                        if (stack.Count > 0)
                        {
                            char currentSymbol = stack.Pop();
                            if (currentSymbol != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                    default:
                        break;
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
