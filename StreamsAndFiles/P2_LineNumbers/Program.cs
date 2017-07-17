using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_LineNumbers
{
    class Program
    {
        static void Main()
        {

            using (var reader = new StreamReader("../../../test1.txt"))
            using (var writer = new StreamWriter("../../../newTest1.txt"))
            {
                var readLine = string.Empty;
                int n = 1;
                while ((readLine = reader.ReadLine()) != null)
                {
                    writer.WriteLine($"{n++} {readLine}");
                }
            }

            
        }
    }
}
