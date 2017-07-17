using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_BasicStackOperations
{
    class Startup
    {
        static void Main()
        {
            int[] comands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] data = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();
            var stack = new Stack<int>();

            for (int i = 0; i < comands[0]; i++)
            {
                stack.Push(data[i]);
            }
            for (int i = 0; i < comands[1]; i++)
            {
                stack.Pop();
            }
            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (stack.Contains(comands[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }
    }
}
