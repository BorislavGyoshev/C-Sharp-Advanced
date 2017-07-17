using System;

namespace P1_MatrixOfPalindromes
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            for (int i = 0; i < int.Parse(input[0]); i++)
            {
                int n = 0;
                for (int j = 0; j < int.Parse(input[1]); j++)
                {
                    Console.Write($"{alphabet[i]}");
                    Console.Write($"{alphabet[i + n++]}");
                    Console.Write($"{alphabet[i]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
