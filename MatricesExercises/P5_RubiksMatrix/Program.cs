using System;
using System.Linq;

namespace P5_RubiksMatrix
{
    class Program
    {
        static void Main()
        {
            int[] size = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[][] matrix = new int[size[0]][];
            int n = 1;
            for (int i = 0; i < size[0]; i++)
            {
                matrix[i] = new int[size[1]];
                for (int j = 0; j < size[1]; j++)
                {
                    matrix[i][j] = n++;
                }
            }
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] comands = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int rowcol = int.Parse(comands[0]);
                long moves = long.Parse(comands[2]);
                int tmp = 0;
                switch (comands[1])
                {
                    case "up":
                        tmp = matrix[0][rowcol];
                        for (int j = 0; j < moves % size[0]; j++)
                        {
                            for (int j1 = 0; j1 < size[0]; j1++)
                            {
                                if (j1 == size[0] - 1)
                                {
                                    matrix[j1][rowcol] = tmp;
                                    tmp = matrix[0][rowcol];
                                }
                                else
                                {
                                    matrix[j1][rowcol] = matrix[j1 + 1][rowcol];
                                }
                            }
                        } break;
                    case "down":
                        tmp = matrix[size[0] - 1][rowcol];
                        for (long j = moves % size[0]; j > 0; j--)
                        {
                            for (int j1 = size[0] - 1; j1 >= 0; j1--)
                            {
                                if (j1 == 0)
                                {
                                    matrix[j1][rowcol] = tmp;
                                    tmp = matrix[size[0] - 1][rowcol];
                                }
                                else
                                {
                                    matrix[j1][rowcol] = matrix[j1 - 1][rowcol];
                                }
                            }
                        } break;
                    case "left":
                        tmp = matrix[rowcol][0];
                        for (int j = 0; j < moves % size[1]; j++)
                        {
                            for (int j1 = 0; j1 < size[1]; j1++)
                            {
                                if (j1 == size[1] - 1)
                                {
                                    matrix[rowcol][size[1] - 1] = tmp;
                                    tmp = matrix[rowcol][0];
                                }
                                else
                                {
                                    matrix[rowcol][j1] = matrix[rowcol][j1 + 1];
                                }
                            }
                        } break;
                    case "right":
                        tmp = matrix[rowcol][size[1] - 1];
                        for (long j = moves % size[1]; j > 0; j--)
                        {
                            for (int j1 = size[1] - 1; j1 >= 0; j1--)
                            {
                                if (j1 == 0)
                                {
                                    matrix[rowcol][j1] = tmp;
                                    tmp = matrix[rowcol][size[1] - 1];
                                }
                                else
                                {
                                    matrix[rowcol][j1] = matrix[rowcol][j1 - 1];
                                }
                            } 
                        } break;
                }
            }
            //for (int i = 0; i < size[0]; i++)
            //{
            //    for (int j = 0; j < size[1]; j++)
            //    {
            //        Console.Write($"{matrix[i][j]} ");
            //    }
            //    Console.WriteLine();
            //}
            n = 1;
            for (int i = 0; i < size[0]; i++)
            {
                for (int j = 0; j < size[1]; j++)
                {
                    if (matrix[i][j] == n)
                    {
                        Console.WriteLine("No swap required");
                        n++;
                    }
                    else
                    {
                        for (int i1 = i; i1 < size[0]; i1++)
                        {
                            for (int j1 = 0; j1 < size[1]; j1++)
                            {
                                if (matrix[i1][j1] == n)
                                {
                                    int tmp = matrix[i][j];
                                    matrix[i][j] = matrix[i1][j1];
                                    matrix[i1][j1] = tmp;
                                    Console.WriteLine($"Swap ({i}, {j}) with ({i1}, {j1})");
                                }
                            }
                        }
                        n++;
                    }
                }
            }

        }
    }
}
