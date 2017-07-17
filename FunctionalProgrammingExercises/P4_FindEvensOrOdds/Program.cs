using System;
using System.Linq;

namespace P4_FindEvensOrOdds
{
    class Program
    {
        static void Main()
        {
            int[] range = Console.ReadLine().Split(new[] { ' ' }).Select(int.Parse).ToArray();
            string str = Console.ReadLine();
            int startIndex = 0;
            if (str == "odd")
            {
                if (range[0] % 2 != 0)
                {
                    startIndex = range[0];
                }
                else
                {
                    startIndex = range[0] + 1;
                }
                for (int i = startIndex; i <= range[1]; i += 2)
                {
                    Console.Write(" {0}", i);
                }
            }
            else
            {
                if (range[0] % 2 == 0)
                {
                    startIndex = range[0];
                }
                else
                {
                    startIndex = range[0] + 1;
                }
                for (int i = startIndex; i <= range[1]; i += 2)
                {
                    Console.Write(" {0}", i);
                }
            }
        }
    }
}
