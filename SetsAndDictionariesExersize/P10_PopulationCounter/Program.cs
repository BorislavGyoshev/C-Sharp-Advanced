using System;
using System.Collections.Generic;
using System.Linq;

namespace P10_PopulationCounter
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split('|');
            Dictionary<string, Dictionary<string, long>> dict = new Dictionary<string, Dictionary<string, long>>();
            while (input[0] != "report")
            {
                string country = input[1];
                string city = input[0];
                long population = long.Parse(input[2]);
                if (!dict.ContainsKey(country))
                {
                    dict.Add(country, new Dictionary<string, long>());
                    dict[country].Add(city, population);
                }
                else
                {
                    if (!dict[country].ContainsKey(city))
                    {
                        dict[country].Add(city, population);
                    }
                    else
                    {
                        dict[country][city] = population;
                    }
                }
                input = Console.ReadLine().Split('|');
            }
            foreach (var country in dict.OrderByDescending(x => x.Value.Values.Sum()))
            {
                long populationCount = country.Value.Values.Sum();

                Console.WriteLine($"{country.Key} (total population: {populationCount})");
                foreach (var city in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
                //Console.WriteLine("{0}", string.Join("\n", country.Value.OrderByDescending(c => c.Value).Select(a => $"=>{a.Key}: {a.Value}")));
            }
        }
    }
}
