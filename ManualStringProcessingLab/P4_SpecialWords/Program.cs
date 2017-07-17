using System;
using System.Collections.Generic;
using System.Linq;

namespace P4_SpecialWords
{
    class Program
    {
        static void Main()
        {
            string[] specialWords = Console.ReadLine().Split(new[] { ' ', '(', ')', '[', ']', '<', '>', ',', '-', '!', '?' });
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string[] text = Console.ReadLine().Split(new[] { ' ', '(', ')', '[', ']', '<', '>', ',', '-', '!', '?' });
            for (int i = 0; i < specialWords.Count(); i++)
            {
                if (!dict.ContainsKey(specialWords[i]))
                {
                    dict.Add(specialWords[i], 0);
                }
            }
            for (int j = 0; j < text.Length; j++)
            {
                if (dict.ContainsKey(text[j]))
                {
                    dict[text[j]]++;
                }
            }

            foreach (var word in dict)
            {
                Console.WriteLine($"{word.Key} - {word.Value}");
            }
        }
    }
}
