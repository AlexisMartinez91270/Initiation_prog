using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFramework
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 4, p = 5, q = 8;
            Console.WriteLine("Calcul 1 ----------------------------------");
            faitCalculs(n, p + 2);
            Console.WriteLine("\nCalcul 2 ----------------------------------");
            faitCalculs(2*n, q);

            Console.ReadLine();
        }

        static void faitCalculs(int x, int y)
        {
            Console.WriteLine("Somme : {0}", x+y);
            Console.WriteLine("Produit : {0}", x * y);
        }
    }
}
