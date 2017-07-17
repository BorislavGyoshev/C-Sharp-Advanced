using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14_DragonArmy
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, SortedDictionary<string, IList<double>>> dragons = new Dictionary<string, SortedDictionary<string, IList<double>>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string type = input[0];
                string name = input[1];
                long damage = 45;
                if (input[2] != "null")
                {
                    damage = long.Parse(input[2]);
                }
                long health = 250;
                if (input[3] != "null")
                {
                    health = long.Parse(input[3]);
                }
                long armor = 10;
                if (input[4] != "null")
                {
                    armor = long.Parse(input[4]);
                }
                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new SortedDictionary<string, IList<double>>());
                    dragons[type].Add(name, new List<double>() {damage, health, armor });
                }
                else
                {
                    if (!dragons[type].ContainsKey(name))
                    {
                        dragons[type].Add(name, new List<double>() { damage, health, armor });
                    }
                    else
                    {
                        dragons[type][name] = new List<double>() { damage, health, armor };
                    }
                }
            }

            foreach (var type in dragons)
            {
                Console.WriteLine($"{type.Key}::({type.Value.Average(d => d.Value[0]):F2}/{type.Value.Average(d => d.Value[1]):F2}/{type.Value.Average(d => d.Value[2]):F2})");
                foreach (var name in type.Value)
                {
                    Console.WriteLine($"-{name.Key} -> damage: {name.Value[0]}, health: {name.Value[1]}, armor: {name.Value[2]}");
                }
            }
        }
    }
}
