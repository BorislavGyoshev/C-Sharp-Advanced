using System;

namespace P12_CharacterMultiplier
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            string firstWord = input[0];
            string secondWord = input[1];
            Console.WriteLine(Multiplied(firstWord, secondWord));

        }
        private static long Multiplied(string firstWord, string secondWord)
        {
            long sum = 0;
            if (firstWord.Length >= secondWord.Length)
            {
                int length1 = firstWord.Length - 1;
                for (int i = 0; i < secondWord.Length; i++)
                {
                    sum += firstWord[i] * secondWord[i];
                    length1--;
                }
                while (length1 >= 0 && firstWord.Length > secondWord.Length)
                {
                    sum += firstWord[length1--];
                }
            }
            else
            {
                int lenght2 = secondWord.Length - 1;
                for (int i = 0; i < firstWord.Length; i++)
                {
                    sum += firstWord[i] * secondWord[i];
                    lenght2--;
                }
                while (lenght2 >= 0)
                {
                    sum += secondWord[lenght2--];
                }
            }
            return sum;
        }
    }
}
