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
            int a = 5;
            int b = a + 4;
            a = a + 1;
            b = a - 4;
            // a = 6 ; b = 2
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
