using System;
using System.IO;

namespace P1_OddLines
{
    class Program
    {
        static void Main()
        {
            using (StreamReader reader = new StreamReader("../../../test1.txt"))
            {
                int n = 0;
                var readLine = reader.ReadLine();
                while (readLine != null)
                {
                    if (n % 2 == 0)
                    {
                        Console.WriteLine(readLine);
                    }
                    readLine = reader.ReadLine();
                    n++;
                }
            }
        }
    }
}
