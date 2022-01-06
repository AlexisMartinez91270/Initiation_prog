using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, p;
            double x;

            n = 10;
            p = 7;
            x = 2.5;

            Console.WriteLine(x + n / p);
            //réel
            Console.WriteLine((x + n) / p);
            //réel
            Console.WriteLine(5.0 * n);
            //réel
            Console.WriteLine((n + 1) / n);
            //entier
            Console.WriteLine((n + 1.0) / n);
            //réel
        }
    }
}
