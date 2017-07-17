using System;
using System.Collections.Generic;

namespace P13_MagicExchangeableWords
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            string firstWord = input[0];
            string secondWord = input[1];
            Console.WriteLine(Exchangeable(firstWord, secondWord));
        }

        private static string Exchangeable(string firstWord, string secondWord)
        {
            int minWordLenght = Math.Min(firstWord.Length, secondWord.Length);
            Dictionary<char, char> dict = new Dictionary<char, char>();
            for (int i = 0; i < minWordLenght; i++)
            {
                if (!dict.ContainsKey(firstWord[i]))
                {
                    dict.Add(firstWord[i], secondWord[i]);
                }
                else
                {
                    if (dict[firstWord[i]] != secondWord[i])
                    {
                        return "false";
                    }
                }
            }
            int maxWordLenght = Math.Max(firstWord.Length, secondWord.Length);
            if (firstWord.Length > secondWord.Length)
            {
                for (int i = minWordLenght; i < maxWordLenght; i++)
                {
                    if (!dict.ContainsKey(firstWord[i]))
                    {
                        return "false";
                    }

                }
            }
            else
            {
                for (int i = minWordLenght; i < maxWordLenght; i++)
                {
                    if (!dict.ContainsValue(secondWord[i]))
                    {
                        return "false";
                    }
                }
            }
            return "true";
        }
    }
}
