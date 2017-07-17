using System;
using System.Collections.Generic;

namespace P6_AMinerTask
{
    class Startup
    {
        static void Main()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string resource = Console.ReadLine();
            while (resource != "stop")
            {
                int amount = int.Parse(Console.ReadLine());
                if (!dict.ContainsKey(resource))
                {
                    dict.Add(resource, amount);
                }
                else
                {
                    dict[resource] += amount;
                }
                resource = Console.ReadLine();
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
