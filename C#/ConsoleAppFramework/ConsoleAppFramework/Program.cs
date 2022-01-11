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
            float capIni, cap, taux;            

            Console.WriteLine("donnez le capital à placer et le taux : ");
            capIni = float.Parse(Console.ReadLine());
            taux = float.Parse(Console.ReadLine());

            cap = capIni;
            int i = 0;

            do
            {
                cap = cap * (1 + taux / 100);                
                i ++;
                Console.WriteLine("capital, à l'année " + i + " : " + cap);
            }while(cap <= 2 * capIni);
        }
    }
}