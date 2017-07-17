using System;
using System.Collections.Generic;
using System.Linq;

namespace P12_LegendaryFarming
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, long> keyMaterials = new Dictionary<string, long>();
            SortedDictionary<string, long> junkMaterials = new SortedDictionary<string, long>();
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);
            bool isObtained = false;
            while (!isObtained)
            {
                string[] input = Console.ReadLine().Split(' ');
                int n = input.Count();

                for (int i = 0; i < n; i += 2)
                {
                    long quantity = long.Parse(input[i]);
                    string material = input[i + 1].ToLower();
                    if (material == "shards" || material == "fragments" || material == "motes")
                    {
                        keyMaterials[material] += quantity;

                        if (keyMaterials[material] >= 250)
                        {
                            keyMaterials[material] -= 250;
                            switch (material)
                            {
                                case "shards": Console.WriteLine("Shadowmourne obtained!"); break;
                                case "fragments": Console.WriteLine("Valanyr obtained!"); break;
                                case "motes": Console.WriteLine("Dragonwrath obtained!"); break;
                            }
                            isObtained = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials.Add(material, quantity);
                        }
                        else
                        {
                            junkMaterials[material] += quantity;
                        }
                    }
                }
            }

            foreach (var material in keyMaterials.OrderByDescending(q => q.Value).ThenBy(m => m.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
            foreach (var material in junkMaterials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}
