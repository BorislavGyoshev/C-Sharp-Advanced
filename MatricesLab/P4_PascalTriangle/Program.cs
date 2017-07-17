using System;

namespace P4_PascalTriangle
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long[][] matrinx = new long[n][];
            matrinx[0] = new long[] { 1 };
            if (n > 1)
            {
                matrinx[1] = new long[] { 1, 1 };
            }
            for (int i = 2; i < n; i++)
            {
                matrinx[i] = new long[i + 1];
                matrinx[i][0] = 1;
                matrinx[i][i] = 1;
                for (int j = 1; j < i; j++)
                {
                    matrinx[i][j] = matrinx[i - 1][j - 1] + matrinx[i - 1][j];
                }

            }
            for (int i = 0; i < matrinx.Length; i++)
            {
                for (int j = 0; j < matrinx[i].Length; j++)
                {
                    Console.Write($"{matrinx[i][j]} ");
                }
                Console.WriteLine();
            }

        }
    }
}
