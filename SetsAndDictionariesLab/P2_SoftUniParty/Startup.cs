using System;
using System.Collections.Generic;

namespace P2_SoftUniParty
{
    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var guests = new SortedSet<string>();
            while (input != "PARTY")
            {
                guests.Add(input);
                input = Console.ReadLine();
            }
            while (input != "END")
            {
                if (guests.Contains(input))
                {
                    guests.Remove(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(guests.Count);
            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
