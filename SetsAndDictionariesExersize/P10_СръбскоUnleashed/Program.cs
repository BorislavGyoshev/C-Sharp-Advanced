using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_СръбскоUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> dict = new Dictionary<string, Dictionary<string, long>>();
            string str = string.Empty;
            while ((str = Console.ReadLine()) != "End")
            {
                try
                {
                    string[] input = str.Split(new string[] { " @" }, StringSplitOptions.RemoveEmptyEntries);
                    if (input.Length < 2)
                    {
                        continue;
                    }
                    var firstTokens = input[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var secondTokens = input[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    var name = string.Join(" ", firstTokens);
                    var town = string.Join(" ", secondTokens.Take(secondTokens.Length - 2));
                    var ticketPrice = long.Parse(secondTokens[secondTokens.Length - 1]);
                    var ticketsCount = long.Parse(secondTokens[secondTokens.Length - 2]);
                    if (!dict.ContainsKey(town))
                    {
                        dict.Add(town, new Dictionary<string, long>());
                        dict[town].Add(name, ticketPrice * ticketsCount);
                    }
                    else
                    {
                        if (!dict[town].ContainsKey(name))
                        {
                            dict[town].Add(name, ticketPrice * ticketsCount);
                        }
                        else
                        {
                            dict[town][name] += ticketPrice * ticketsCount;
                        }
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }

            foreach (var town in dict)
            {
                Console.WriteLine(town.Key);
                foreach (var name in town.Value.OrderByDescending(m => m.Value))
                {
                    Console.WriteLine($"#  {name.Key} -> {name.Value}");
                }
            }
        }
    }
}