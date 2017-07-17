using System;
using System.Collections.Generic;

namespace P8_HandsOfCards
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries);
            string[] fixInput = input.s
            Dictionary<string, HashSet<string>> dict = new Dictionary<string, HashSet<string>>();

            while (input[0] != "JOKER")
            {
                if (!dict.ContainsKey(input[0]))
                {
                    dict.Add(input[0], new HashSet<string>(input));
                }
                else
                {
                    dict[input[0]] += multipleCards(input);
                }
                input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} {item.Value}");
            }
        }

        private static HashSet<string> AddCards(Dictionary<string, HashSet<string>> dict, string[] input)
        {
            throw new NotImplementedException();
        }

        private static int multipleCards(string[] input)
        {
            int result = 0;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i].Length == 2)
                {
                    int tmp = 0;
                    switch (input[i].Substring(0,1))
                    {
                        case "J": tmp = 11; break;
                        case "Q": tmp = 12; break;
                        case "K": tmp = 13; break;
                        case "A": tmp = 14; break;
                        default: tmp = int.Parse(input[i].Substring(0,1)); break;
                    }
                    switch (input[i].Substring(1,1))
                    {
                        case "S": result += tmp * 4; break;
                        case "H": result += tmp * 3; break;
                        case "D": result += tmp * 2; break;
                        case "C": result += tmp * 1; break;
                    }
                }
                else
                {
                    switch (input[i].Substring(2,1))
                    {
                        case "S": result += 10 * 4; break;
                        case "H": result += 10 * 3; break;
                        case "D": result += 10 * 2; break;
                        case "C": result += 10 * 1; break;
                    }
                }
            }
            return result;
        }
    }
}
