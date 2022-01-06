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
            int n = 8;
            int p = 13;
            int q = 29;

            Console.WriteLine(n + p / q);
            // 8
            Console.WriteLine(n + q / p);
            // 10
            Console.WriteLine((n + q) / p);
            // 2
            Console.WriteLine(n + p / n + p);
            // 22
            Console.WriteLine((n + p) / (n + p));
            // 1
        }
    }
}
