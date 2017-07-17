using System;
using System.Collections.Generic;

namespace DecimalToBinaryConverter
{
    class Startup
    {
        static void Main()
        {
            int decimalNumber = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            if (decimalNumber == 0)
            {
                Console.WriteLine(0);
            }
            while (decimalNumber > 0)
            {
                stack.Push(decimalNumber % 2);
                decimalNumber /= 2; 
            }
            foreach (var n in stack)
            {
                Console.Write(n);
            }
        }
    }
}
