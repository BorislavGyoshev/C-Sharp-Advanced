using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P81_MultiplyBigNumber
{
    class Program
    {
        static void Main()
        {
            string firstNumber = Console.ReadLine().TrimStart(new[] { ' ' }).TrimEnd(new[] { ' ' });
            int secondNumber = int.Parse(Console.ReadLine().TrimStart(new[] { ' ' }).TrimEnd(new[] { ' ' }));
            Stack<int> stack = new Stack<int>();
            Stack<int> resultStack = new Stack<int>();
            if (secondNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }
            for (int i = 0; i < firstNumber.Length; i++)
            {
                stack.Push(int.Parse(firstNumber[i].ToString()));
            }
            int tmp = 0;
            while (stack.Count > 0)
            {
                int number = stack.Pop() * secondNumber + tmp;
                if (number > 9)
                {
                    string result = number.ToString();
                    resultStack.Push(int.Parse(result[1].ToString()));
                    tmp = int.Parse(result[0].ToString());
                }
                else
                {
                    resultStack.Push(number);
                    tmp = 0;
                }
            }
            if (tmp > 0)
            {
                resultStack.Push(tmp);
            }
            StringBuilder sb = new StringBuilder();
            while (resultStack.Count > 0)
            {
                sb.Append(resultStack.Pop());
            }
            if (sb.ToString() == "0")
            {
                Console.WriteLine(0);
                return;
            }
            Console.WriteLine(sb.ToString().TrimStart(new[] { '0' }));
        }
    }
}
