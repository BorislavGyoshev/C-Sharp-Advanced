using System;

namespace P10_UnicodeCharacters
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine().Normalize();
            for (int i = 0; i < text.Length; i++)
            {
                int tmp = text[i];
                Console.Write(string.Format("\\u{0:x4}", tmp));
            }
            Console.WriteLine();
        }
    }
}
