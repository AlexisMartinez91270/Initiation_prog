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
            double prix, articles, tva;
            Console.WriteLine("prix unitaire HT :");
            prix = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nombres articles :");
            articles = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("taux TVA :");
            tva = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("prix total HT: " + (prix * articles));
            Console.WriteLine("prix total TTC: " + (prix * articles * (1 + tva * 0.01)));

        }
    }
}
