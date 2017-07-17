using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_PoisonousPlants
{
    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] plants = Console.ReadLine().Split(' ')
                .Select(x => Convert.ToInt32(x)).ToArray();
            int[] days = new int[n];
            Stack<int> proximityStack = new Stack<int>();
            proximityStack.Push(0);
            for (int i = 1; i < plants.Length; i++)
            {
                int maxDeys = 0;
                while (proximityStack.Count > 0 && plants[proximityStack.Peek()] >= plants[i])
                {
                    maxDeys = Math.Max(maxDeys, days[proximityStack.Pop()]);
                }

                if (proximityStack.Count > 0)
                {
                    days[i] = maxDeys + 1;
                }
                proximityStack.Push(i);
            }
            Console.WriteLine(days.Max());
        }
    }
}
