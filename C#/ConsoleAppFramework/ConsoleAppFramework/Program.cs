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
            // a = 5 ; b = - ; c = -
            int b = 3;
            // a = 5 ; b = 3 ; c = -
            int c = a + b;
            // a = 5 ; b = 3 ; c = 8
            a = 2;
            // a = 2 ; b = 3 ; c = 8
            c = b - a;
            // a = 2 ; b = 3 ; c = 1
            Console.WriteLine(a, b, c); 
        }
    }
}
