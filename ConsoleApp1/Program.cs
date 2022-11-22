using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool chack = false;
            Console.WriteLine("bool default: " + chack);

            Console.WriteLine();

            double d = 1;
            double c = 3;
            Console.WriteLine(d/c);

            Console.WriteLine();

            decimal e = 1;
            decimal f = 3;
            Console.WriteLine(e/f); 

            Console.ReadKey();
        }
    }
}
