using System;
using System.Collections.Generic;

namespace P7_FixEmails
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var people = new Dictionary<string, string>();

            while (input != "stop")
            {
                var email = Console.ReadLine();

                if (!email.EndsWith("us", StringComparison.OrdinalIgnoreCase) && !email.EndsWith("uk", StringComparison.OrdinalIgnoreCase))
                {
                    people.Add(input, email);
                }

                input = Console.ReadLine();
            }

            foreach (var person in people)
            {
                Console.WriteLine($"{person.Key} -> {person.Value}");
            }
        }
    }
}
