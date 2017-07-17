using System;
using System.Collections.Generic;

namespace P5_CalculateSequenceWithQueue
{
    class Startup
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            Queue<long> queue = new Queue<long>();
            queue.Enqueue(n);
            for (int i = 0; i < 50; i++)
            {                
                queue.Enqueue(n + 1);
                queue.Enqueue(2 * n + 1);
                queue.Enqueue(n + 2);
                Console.Write(queue.Dequeue() + " ");
                n = queue.Peek();
            }
        }
    }
}
