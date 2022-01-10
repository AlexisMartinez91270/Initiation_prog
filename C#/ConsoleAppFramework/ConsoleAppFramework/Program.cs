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
            int c = 4;

            if ((a < b) & (b < c))
            {
                Console.WriteLine("Ordre croissant");
            }
            else
            {
                Console.WriteLine("Pas ordre croissant");
            }
        }
    }
}