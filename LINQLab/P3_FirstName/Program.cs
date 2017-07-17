using System;
using System.Linq;

namespace P3_FirstName
{
    class Program
    {
        static void Main()
        {
            string[] people = Console.ReadLine().Split();
            var letters = Console.ReadLine().Split().OrderBy(w => w);
            string result;
            foreach (var letter in letters)
            {
                result = people
                    .Where(w => w.ToLower()
                    .StartsWith(letter.ToLower()))
                    .FirstOrDefault();
                if (result != null)
                {
                    Console.WriteLine(result);
                    return;
                }
            }
            Console.WriteLine("No match");
        }
    }
}
