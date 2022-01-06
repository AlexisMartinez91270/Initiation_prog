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
            int a, b;
            Console.WriteLine("donnez deux nombres");
            a = (int.Parse(Console.ReadLine()));
            Console.WriteLine("donnez deux nombres");
            b = (int.Parse(Console.ReadLine()));
            Console.WriteLine("Leur somme est " + (a + b));
            Console.WriteLine("Leur produit est " + a * b);
        }
    }
}
