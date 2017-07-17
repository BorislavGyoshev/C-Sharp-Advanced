using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Startup
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int num = int.Parse(Console.ReadLine());
            int currentNum = 1;
            Queue<string> queue = new Queue<string>(input);
            while (queue.Count > 1)
            {
                if (currentNum == num)
                {
                    Console.WriteLine($"Removed {queue.Peek()}");
                    queue.Dequeue();
                    currentNum = 1;
                }
                else
                {
                    queue.Enqueue(queue.Peek());
                    queue.Dequeue();
                    currentNum++;
                }
            }
            Console.WriteLine($"Last is {queue.Peek()}");
        }
    }
}
