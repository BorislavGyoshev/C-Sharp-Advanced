using System;
using System.Text;

namespace P2_StringLength
{
    public class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            var sb = new StringBuilder(20);
            sb.Append(text).Append('*', 20 - sb.Length);
            Console.WriteLine(sb);
        }
    }
}
