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

            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine("table de "+ i + " ---------------------------------");
                for (int j = 1; j <= 10; j++)
                {
                    n = i * j;
                    Console.WriteLine(n);
                }
            }
        }
    }
}