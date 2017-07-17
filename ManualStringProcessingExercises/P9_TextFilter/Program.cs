using System;
using System.Text;

namespace P9_TextFilter
{
    class Program
    {
        static void Main()
        {
            string[] bannedWords = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(text);
            for (int i = 0; i < bannedWords.Length; i++)
            {
                sb.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
            }
            Console.WriteLine(sb);
        }
    }
}
