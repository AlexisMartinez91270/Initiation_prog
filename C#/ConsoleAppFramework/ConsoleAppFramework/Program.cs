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
            int n;
            do
            {
                Console.WriteLine("Saisir un nombre positif et inférieur à 100");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine(n);
            } while (n < 0 | n > 100);
            Console.WriteLine("merci pour le nombre " + n);

        }
    }
}