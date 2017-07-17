using System;
using System.Text;

namespace P1_ReverseString
{
    public class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            var sb = new StringBuilder();
            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }
            Console.WriteLine(sb);
        }
    }
}
