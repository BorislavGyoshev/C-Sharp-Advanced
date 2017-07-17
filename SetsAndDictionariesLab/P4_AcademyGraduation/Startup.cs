using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_AcademyGraduation
{
    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, double> dict = new SortedDictionary<string, double>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double[] values = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                dict.Add(name, values[0]);
                for (int j = 1; j < values.Count(); j++)
                {
                    dict[name] = (dict[name] + values[j]);
                }
                dict[name] = dict[name] / values.Count();
            }
            foreach (var name in dict)
            {
                Console.WriteLine($"{name.Key} is graduated with {name.Value}");
            }
        }
    }
}
