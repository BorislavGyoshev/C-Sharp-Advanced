using System;
using System.Collections.Generic;
using System.Text;

namespace P11_Palindromes
{
    class Program
    {
        static void Main()
        {
            SortedSet<string> output = new SortedSet<string>();
            string[] input = Console.ReadLine().Split(new[] { ' ', ',', '.', '?', '!' },StringSplitOptions.RemoveEmptyEntries);
            if (input.Length == 0)
            {
                //Console.WriteLine("[]");
                return;
            }
            List<string> listRevers = new List<string>();
            List<string> list = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                list.Add(input[i]);
                string str = string.Empty;
                string word = input[i];
                for (int j = input[i].Length - 1; j >= 0; j--)
                {
                    str += word[j];
                }
                listRevers.Add(str);
                if (list[i] == listRevers[i])
                {
                    output.Add(list[i]);
                }
            }
            //StringBuilder sb = new StringBuilder();
            //sb.Append("[");
            //foreach (var item in output)
            //{
            //    sb.Append($"{item}, ");
            //}
            //sb.Remove(sb.Length - 2, 2);
            //sb.Append("]");
            //Console.WriteLine(sb);
            Console.WriteLine("[" + string.Join(", ", output) + "]");
        }
    }
}
