using System;

namespace P1_StudentsResults
{
    public class P1_StudentsResults
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0,-10}|{1,7:F2}|{2,7:F2}|{3,7:F2}|{4,7:F2}|", "Name", "CAdv", "COOP", "AdvOOP", "Average");
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(new[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var name = tokens[0];
                var firstName = double.Parse(tokens[1]);
                var secondName = double.Parse(tokens[2]);
                var thirdName = double.Parse(tokens[3]);
                var average = (firstName + secondName + thirdName) / 3;
                Console.WriteLine("{0,-10}|{1,7:F2}|{2,7:F2}|{3,7:F2}|{4,7:F4}|", name, firstName, secondName, thirdName, average);
            }
        }
    }
}
