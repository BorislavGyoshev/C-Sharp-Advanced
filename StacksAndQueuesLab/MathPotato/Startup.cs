﻿using System;
using System.Collections.Generic;

namespace MathPotato
{
    class Startup
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int num = int.Parse(Console.ReadLine());
            int cycle = 1;
            Queue<string> queue = new Queue<string>(input);
            while (queue.Count > 1)
            {
                for (int i = 0; i < num - 1; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                if (PrimeTool.IsPrime(cycle))
                {
                    Console.WriteLine($"Prime {queue.Peek()}");
                }
                else
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                }
                cycle++;
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }

        public static class PrimeTool
        {
            public static bool IsPrime(int candidate)
            {
                // Test whether the parameter is a prime number.
                if ((candidate & 1) == 0)
                {
                    if (candidate == 2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                // Note:
                // ... This version was changed to test the square.
                // ... Original version tested against the square root.
                // ... Also we exclude 1 at the end.
                for (int i = 3; (i * i) <= candidate; i += 2)
                {
                    if ((candidate % i) == 0)
                    {
                        return false;
                    }
                }
                return candidate != 1;
            }
        }
    }
}
