using System;

namespace P3_FormattingNumbers
{
    public class Program
    {
        public static void Main()
        {
            string[] numbers = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            long a = long.Parse(numbers[0]);
            double b = double.Parse(numbers[1]);
            double c = double.Parse(numbers[2]);
            string aToHex = a.ToString("X");
            string aToBinary = Convert.ToString(a, 2).PadLeft(10, '0');
            if (aToBinary.Length > 10)
            {
                aToBinary = aToBinary.Remove(10);
            }
            Console.WriteLine("|{0,-10}|{1,10}|{2,10:f2}|{3,-10:f3}|", aToHex, aToBinary, b, c);
        }
    }
}
