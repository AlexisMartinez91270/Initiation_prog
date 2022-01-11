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
            int jours = 0;
            float mois;
            Console.WriteLine("Saisir un numéro de mois");


            do
            {
                mois = float.Parse(Console.ReadLine());
                mois = Math.Abs(mois - 7.5f) - 0.5f;

                if(mois > 6)
                {
                    Console.WriteLine("Entre 1 & 12");
                }
                else
                {
                    jours = (mois % 2 == 0) ? 31 : ((mois == 5) ? 28 : 30);
                }                  
            } while (mois > 6);
            Console.WriteLine(jours);
        }
    }
}