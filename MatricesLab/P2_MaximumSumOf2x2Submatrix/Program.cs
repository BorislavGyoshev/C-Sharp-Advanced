using System;
using System.Linq;

namespace P2_MaximumSumOf2x2Submatrix
{
    class Program
    {
        static void Main()
        {
            int[] matriceSize = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = matriceSize[0];
            int cols = matriceSize[1];
            int[][] matrices = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                matrices[i] = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }
            int rowi = matrices[0][0];
            int rowi1 = matrices[1][0];
            int colj = matrices[0][1];
            int colj1 = matrices[1][1];
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    if (rowi + rowi1 + colj + colj1 < matrices[i][j] + matrices[i + 1][j] + matrices[i][j + 1] + matrices[i + 1][j + 1])
                    {
                        rowi = matrices[i][j];
                        rowi1 = matrices[i + 1][j];
                        colj = matrices[i][j + 1];
                        colj1 = matrices[i + 1][j + 1];
                    }
                }
            }

            Console.WriteLine($"{rowi} {colj}");
            Console.WriteLine($"{rowi1} {colj1}");
            Console.WriteLine(rowi + rowi1 + colj + colj1);
        }
    }
}
