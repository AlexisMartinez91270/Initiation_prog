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
            //a)
            int n1 = 5;
            int n2 = 7;
            n1 = n2;
            n2 = n1;
            // n1 = 7 ; n2 = 7
            Console.WriteLine(n1);
            Console.WriteLine(n2);

            //b)
            n1 = 5;
            n2 = 7;
            n2 = n1;
            n1 = n2;
            // n1 = 5 ; n2 = 5
            Console.WriteLine(n1);
            Console.WriteLine(n2);
        }
    }
}
