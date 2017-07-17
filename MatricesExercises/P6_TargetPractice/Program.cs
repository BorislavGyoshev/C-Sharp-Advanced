using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P6_TargetPractice
{
    class Program
    {
        static void Main()
        {
            int[] rc = Console.ReadLine().Split(new char[] { ' ' }).Select(int.Parse).ToArray();
            string pattern = Console.ReadLine();
            int[] shot = Console.ReadLine().Split(new char[] { ' ' }).Select(int.Parse).ToArray();
            char[][] matrix = new char[rc[0]][];
            bool left = true;
            int patternLenght = pattern.Length;
            for (int i = rc[0] - 1; i >= 0; i--)
            {
                matrix[i] = new char[rc[1]];
                if (left == true)
                {
                    for (int j = rc[1] - 1; j >= 0; j--)
                    {
                        if (patternLenght == pattern.Length)
                        {
                            patternLenght = 0;
                        }
                        matrix[i][j] = pattern[patternLenght++];
                    }
                    left = false;
                }
                else
                {
                    for (int j = 0; j < rc[1]; j++)
                    {
                        if (patternLenght == pattern.Length)
                        {
                            patternLenght = 0;
                        }
                        matrix[i][j] = pattern[patternLenght++];
                    }
                    left = true;
                }
            }
            for (int i = 0; i < matrix.Length; i++) // Process shot impact
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (IsCellShooted(i, j, shot[0], shot[1], shot[2]))
                    {
                        matrix[i][j] = ' ';
                    }
                }
            }
            for (int i = 0; i < rc[0]; i++)
            {
                for (int j = 0; j < rc[1]; j++)
                {
                    Console.Write($"{matrix[i][j]} ");
                }
                Console.WriteLine();
            }
        }
        private static bool IsCellShooted(int i, int j, int impactRow, int impactCol, int impactRadius)
        {
            var distance = Math.Sqrt((i - impactRow) * (i - impactRow) + (j - impactCol) * (j - impactCol));
            return distance <= impactRadius;
        }
    }
}
