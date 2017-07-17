using System;
using System.Collections.Generic;
using System.Linq;

namespace P3_2x2SquaresInMatrix
{
    class Program
    {
        static void Main()
        {
            int[] nm = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[][] matrix = new string[nm[0]][];
            List<int> col = new List<int>();
            int count = 0;
            for (int i = 0; i < nm[0]; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries).ToArray();
                matrix[i] = new string[input.Count()];
                for (int j = 0; j < nm[1]; j++)
                {
                    matrix[i][j] = input[j];
                    if (j > 0)
                    {
                        if (matrix[i][j] == matrix[i][j - 1])
                        {
                            col.Add(j - 1);
                        }
                    }
                }
                for (int k = 0; k < col.Count; k++)
                {
                    if (i > 0 && k < col.Count && k < matrix[i].Count() - 1)
                    {
                        if (matrix[i][col[k]] == matrix[i - 1][col[k]] && matrix[i][col[k] + 1] == matrix[i - 1][col[k] + 1])
                        {
                            count++;
                        }
                    }
                }
                col.Clear();
            }
            if (nm[0] > 1 && nm[1] > 1)
            {
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine("No 2 x 2 squares of equal cells exist.");
            }
        }
    }
}
