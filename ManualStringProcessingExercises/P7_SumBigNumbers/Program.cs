using System;
using System.Collections.Generic;
using System.Linq;

namespace P7_SumBigNumbers
{
    class Program
    {
        static void Main()
        {
            char[] firstNumber = Console.ReadLine().ToArray();
            char[] secondNumber = Console.ReadLine().ToArray();
            Stack<string> stack = new Stack<string>();
            int tmp = 0;
            string result = string.Empty;
            if (firstNumber.Length >= secondNumber.Length)
            {
                long n = firstNumber.Length - 1;
                for (long i = secondNumber.Length - 1; i >= 0; i--)
                {
                    if (tmp + (firstNumber[n] - '0') + (secondNumber[i] - '0') > 9)
                    {
                        result = (tmp + (firstNumber[n] - '0') + (secondNumber[i] - '0')).ToString();
                        tmp = int.Parse(result[0].ToString());
                        stack.Push(result[1].ToString());
                    }
                    else
                    {
                        stack.Push((tmp + (firstNumber[n] - '0') + (secondNumber[i] - '0')).ToString());
                        tmp = 0;
                    }
                    n--;
                }
                for (long j = firstNumber.Length - secondNumber.Length - 1; j >= 0; j--)
                {
                    if (tmp + (firstNumber[j] - '0') > 9)
                    {
                        result = (tmp + (firstNumber[j] - '0')).ToString();
                        tmp = int.Parse(result[0].ToString());
                        stack.Push(result[1].ToString());
                    }
                    else
                    {
                        stack.Push((tmp + (firstNumber[j] - '0')).ToString());
                        tmp = 0;
                    }
                }
            }
            else
            {
                long m = secondNumber.Length - 1;
                for (long i = firstNumber.Length - 1; i >= 0; i--)
                {
                    if (tmp + (firstNumber[i] - '0') + (secondNumber[m] - '0') > 9)
                    {
                        result = (tmp + (firstNumber[i] - '0') + (secondNumber[m] - '0')).ToString();
                        tmp = int.Parse(result[0].ToString());
                        stack.Push(result[1].ToString());
                    }
                    else
                    {
                        stack.Push((tmp + (firstNumber[i] - '0') + (secondNumber[m] - '0')).ToString());
                        tmp = 0;
                    }
                    m--;
                }
                for (long j = secondNumber.Length - firstNumber.Length - 1; j >= 0; j--)
                {
                    if (tmp + (secondNumber[j] - '0') > 9)
                    {
                        result = (tmp + (secondNumber[j] - '0')).ToString();
                        tmp = int.Parse(result[0].ToString());
                        stack.Push(result[1].ToString());
                    }
                    else
                    {
                        stack.Push((tmp + (secondNumber[j] - '0')).ToString());
                        tmp = 0;
                    }
                }
            }
            if (tmp != 0)
            {
                stack.Push(tmp.ToString());
            };
            while (stack.Count > 0)
            {            
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
