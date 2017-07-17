using System;
using System.Linq;

namespace P4_MaximalSum
{
    class Program
    {
        static void Main()
        {
            int[] size = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[][] matrix = new int[size[0]][];
            int sum = 0;
            int[] result = new int[9];
            for (int i = 0; i < size[0]; i++)
            {
                matrix[i] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();                
            }
            for (int i = 0; i < size[0] - 2; i++)
            {
                for (int j = 0; j < size[1] - 2; j++)
                {
                    int tmp = matrix[i][j] + matrix[i][j + 1] + matrix[i][j + 2] + matrix[i + 1][j] + matrix[i + 1][j + 1] + matrix[i + 1][j + 2]
                    + matrix[i + 2][j] + matrix[i + 2][j + 1] + matrix[i + 2][j + 2];
                    if (sum < tmp)
                    {
                        sum = tmp;
                        result[0] = matrix[i][j];
                        result[1] = matrix[i][j + 1];
                        result[2] = matrix[i][j + 2];
                        result[3] = matrix[i + 1][j];
                        result[4] = matrix[i + 1][j + 1];
                        result[5] = matrix[i + 1][j + 2];
                        result[6] = matrix[i + 2][j];
                        result[7] = matrix[i + 2][j + 1];
                        result[8] = matrix[i + 2][j + 2];
                    }
                }
            }
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"{result[0]} {result[1]} {result[2]}\n{result[3]} {result[4]} {result[5]}\n{result[6]} {result[7]} {result[8]}");
        }
    }
}
