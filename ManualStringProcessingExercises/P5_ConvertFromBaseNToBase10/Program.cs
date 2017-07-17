using System;
using System.Linq;
using System.Numerics;

namespace P5_ConvertFromBaseNToBase10
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(input[0]);
            char[] number = input[1].ToArray();
            BigInteger result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                result = result * n + (number[i] - '0');
            }
            Console.WriteLine(result);
        }
    }
}
