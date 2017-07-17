using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace P4_ConvertFromBase10ToBaseN
{
    class Program
    {
        static void Main()
        {
            BigInteger[] numbers = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(BigInteger.Parse).ToArray();
            BigInteger n = numbers[0];
            if (n < 2 || n > 10)
            {
                return;
            }
            BigInteger number = numbers[1];
            if (number == 0)
            {
                Console.WriteLine(0);
                return;
            }
            Stack<BigInteger> stack = new Stack<BigInteger>();
            while (number > 0)
            {
                stack.Push(number % n);
                number /= n;
            }
            int count = stack.Count; 
            for (int i = 0; i < count; i++)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
