using System;
using System.Collections.Generic;
using System.Linq;

namespace P3_MaximumElement
{
    class Startup
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            int minValue = int.MinValue;
            int amount = int.Parse(Console.ReadLine());
            for (int i = 0; i < amount; i++)
            {
                int[] comand = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
                switch (comand[0])
                {
                    case 1:
                        stack.Push(comand[1]);
                        if (comand[1] > minValue)
                        {
                            stack2.Push(comand[1]);
                            minValue = comand[1]; 
                        }; break;
                    case 2:
                        if (stack2.Peek() == stack.Pop())
                        {
                            stack2.Pop();
                            if (stack2.Count > 0)
                            {                                
                                minValue = stack2.Peek();
                            }
                            else
                            {
                                minValue = int.MinValue;
                            }                            
                        }; break;
                    case 3: Console.WriteLine(stack2.Peek()); break;
                }
            }
        }
    }
}
