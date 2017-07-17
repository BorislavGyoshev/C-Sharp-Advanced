using System;
using System.Linq;

namespace P1_SumMatrixElements
{
    class Program
    {
        static void Main()
        {
            int[] dimention = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int row = dimention[0];
            int col = dimention[1];
            int sum = 0;
            int[,] matrix = new int[row, col];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] arr = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = arr[j];
                }
            }
            Console.WriteLine(row);
            Console.WriteLine(col);
            foreach (var item in matrix)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
