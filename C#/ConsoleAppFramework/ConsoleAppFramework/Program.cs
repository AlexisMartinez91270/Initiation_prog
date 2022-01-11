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
            int n, minNeg = 0, maxPos = 0;           

            do
            {
                Console.WriteLine("Rentrer un nombre / ou rentrer 0 pour arrêter");
                n = int.Parse(Console.ReadLine());
                if (n > 0)
                {
                    if (n > maxPos)
                    {
                        maxPos = n;
                    }
                }
                else if (n < 0)
                {
                    if (n < minNeg)
                    {
                        minNeg = n;
                    }
                }
            }while (n != 0);
            
            Console.WriteLine(minNeg);
            Console.WriteLine(maxPos);  
        }
    }
}