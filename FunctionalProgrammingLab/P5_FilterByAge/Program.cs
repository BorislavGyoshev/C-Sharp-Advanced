using System;
using System.Collections.Generic;

namespace P5_FilterByAge
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                dict.Add(input[0], int.Parse(input[1]));
            }
            var conditions = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Func<int, bool> tester = CreateTester(conditions, age);
            Action<KeyValuePair<string, int>> printer = CreatePrinter(format);
            InvokePrinter(dict, tester, printer);
        }

        private static void InvokePrinter(Dictionary<string, int> dict, Func<int, bool> tester, Action<KeyValuePair<string, int>> printer)
        {
            foreach (var person in dict)
            {
                if (tester(person.Value))
                {
                    printer(person);
                }
            }
        }

        private static Action<KeyValuePair<string, int>> CreatePrinter(string format)
        {
            switch (format)
            {
                case "name age": return p => Console.WriteLine($"{p.Key} - {p.Value}");
                case "name": return p => Console.WriteLine($"{p.Key}");
                case "age": return p => Console.WriteLine($"{p.Value}");
                default: return null;
            }
        }

        private static Func<int, bool> CreateTester(string conditions, int age)
        {
            if (conditions == "older")
            {
                return n => n >= age;
            }
            else
            {
                return n => n < age;

            }
        }
    }
}
