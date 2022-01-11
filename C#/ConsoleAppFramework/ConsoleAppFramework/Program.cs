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
            string s = "Bonjour je m'appelle Alexis.";            
            int i = 0;

            for (i = 0; i < s.Length; ++i)
            {
                Console.WriteLine("" + s[i]);
            }
            Console.WriteLine(i - 1);   
        }
    }
}