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
            int jours;
            int mois;
            Console.WriteLine("Saisir un numéro de mois");
            mois = int.Parse(Console.ReadLine());

            if (mois == 2)
            {
                jours = 28;
            }
            else if (mois <= 7)
            {
                if (mois % 2 == 1)
                {
                    jours = 31;
                }
                else
                {
                    jours = 30;
                }
            }
            else
            {
                if (mois % 2 == 0)
                {
                    jours = 31;
                }
                else
                {
                    jours = 30;
                }
            }
            Console.WriteLine(jours);
        }
    }
}