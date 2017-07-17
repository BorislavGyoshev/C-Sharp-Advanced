using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P1_ParkingLot
{
    class Startup
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var parking = new SortedSet<string>();

            while (input != "END")
            {
                var inputParams = Regex.Split(input, ", ");
                if (inputParams[0] == "IN")
                {
                    parking.Add(inputParams[1]);
                }
                else
                {
                    if (parking.Contains(inputParams[1]))
                    {
                        parking.Remove(inputParams[1]);
                    }
                }
                input = Console.ReadLine();
            }
            if (parking.Count > 0)
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
