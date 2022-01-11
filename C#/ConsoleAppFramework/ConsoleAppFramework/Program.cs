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
            int n = 7;
            int carr;
            for (int i = 0; i < 20-(7-1); i++)
            {
                carr = (n+i)* (n + i);
                Console.WriteLine(carr);
            }          
        }
    }
}