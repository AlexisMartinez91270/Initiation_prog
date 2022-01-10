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
            float montant;
            float tauxRemise = 0f;
            Console.WriteLine("Saisir un montant");
            montant = float.Parse(Console.ReadLine());
            if (montant > 2000)
            {
                tauxRemise = 1f;
                montant *= 1f - tauxRemise / 100f;
            }
            Console.WriteLine(montant);
        }
    }
}