using System;
using System.Linq;

namespace P3_DiagonalDifference
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];
            int d1 = 0;
            int d2 = 0;
            int tmp = n;
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                matrix[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    matrix[i][j] = input[j];
                    if (i == j)
                    {
                        d1 += input[j];
                    }
                }
                d2 += input[--tmp];
            }
            int sum = Math.Abs(d1 - d2);
            Console.WriteLine(sum);
        }
    }
}
