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
            float montantTTC;
            float tauxRemise = 0;
            Console.WriteLine("Saisir un montant");
            montant = float.Parse(Console.ReadLine());
            montantTTC = montant * 1.196f;
            if ((montantTTC >= 1000f) & (montantTTC < 2000f))
            {
                tauxRemise = 1f;
            }
            else if ((montantTTC >= 2000f) & (montantTTC < 5000f))
            {
                tauxRemise = 2f;
            }
            else if (montantTTC >= 5000)
            {
                tauxRemise = 5f;
            }

            montantTTC *= 1f - tauxRemise / 100f;
            Console.WriteLine(montantTTC);
        }
    }
}