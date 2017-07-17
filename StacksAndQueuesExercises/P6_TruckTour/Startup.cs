using System;
using System.Collections.Generic;
using System.Linq;

namespace P6_TruckTour
{
    class Startup
    {
        static void Main()
        {
            int petrolPumpsCount = int.Parse(Console.ReadLine());
            Queue<int> distance = new Queue<int>();
            Queue<int> petrolAmount = new Queue<int>();
            for (int i = 0; i < petrolPumpsCount; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
                petrolAmount.Enqueue(input[0]);
                distance.Enqueue(input[1]);
            }
            int currentPetrol = 0;
            bool isFinished = true;
            for (int i = 0; i < petrolPumpsCount; i++)
            {
                for (int j = 0; j < petrolPumpsCount; j++)
                {
                    if (currentPetrol + petrolAmount.Peek() >= distance.Peek())
                    {
                        currentPetrol += petrolAmount.Peek() - distance.Peek();
                        petrolAmount.Enqueue(petrolAmount.Dequeue());
                        distance.Enqueue(distance.Dequeue());                        
                    }
                    else
                    {
                        isFinished = false;
                        petrolAmount.Enqueue(petrolAmount.Dequeue());
                        distance.Enqueue(distance.Dequeue());
                    }
                }
                if (isFinished == true)
                {
                    Console.WriteLine(i);
                    break;
                }
                else
                {
                    petrolAmount.Enqueue(petrolAmount.Dequeue());
                    distance.Enqueue(distance.Dequeue());
                    currentPetrol = 0;
                    isFinished = true;
                }
            }
        }
    }
}
