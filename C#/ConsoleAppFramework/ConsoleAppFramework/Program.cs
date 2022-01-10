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
            int b = 8;

            if (a < b)
            {
                Console.WriteLine("Ordre croissant");
                Console.WriteLine(b - a);
            }
            else
            {
                Console.WriteLine("Ordre décroissant");
                Console.WriteLine(a - b);
            }
        }
    }
}