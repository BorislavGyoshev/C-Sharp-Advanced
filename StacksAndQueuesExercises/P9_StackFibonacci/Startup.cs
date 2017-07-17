using System;
using System.Collections.Generic;

namespace P9_StackFibonacci
{
    class Startup
    {
        static void Main()
        {
            int nthNumber = int.Parse(Console.ReadLine());
            Stack<long> fibNumbers = new Stack<long>();
            long previousNumber = 0;
            fibNumbers.Push(1);
            for (int i = 0; i < nthNumber - 1; i++)
            {
                long tmp = fibNumbers.Peek();
                fibNumbers.Push(previousNumber + tmp);
                previousNumber = tmp;
            }
            Console.WriteLine(fibNumbers.Peek());
        }
    }
}
