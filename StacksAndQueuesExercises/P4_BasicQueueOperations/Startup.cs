using System;
using System.Collections.Generic;
using System.Linq;

namespace P4_BasicQueueOperations
{
    class Startup
    {
        static void Main()
        {
            int[] comands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] data = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToInt32(x)).ToArray();
            var queue = new Queue<int>();

            for (int i = 0; i < comands[0]; i++)
            {
                queue.Enqueue(data[i]);
            }
            for (int i = 0; i < comands[1]; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (queue.Contains(comands[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
        }
    }
}
