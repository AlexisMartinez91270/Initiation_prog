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
            int n, sommeNeg = 0, sommePos = 0, iNeg = 0, iPos = 0;
            float moyNeg, moyPos;


            do
            {
                Console.WriteLine("Rentrer un nombre / ou rentrer 0 pour arrêter");
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    iNeg++;
                    sommeNeg += n;
                }
                else if (n > 0)
                {
                    iPos++;
                    sommePos += n;
                }
            }while (n != 0);
            moyNeg = sommeNeg/iNeg;
            moyPos = sommePos/ iPos;
            Console.WriteLine(moyNeg);
            Console.WriteLine(moyPos);  
        }
    }
}