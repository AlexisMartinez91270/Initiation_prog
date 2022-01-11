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
            int[] array1 = new int[5];
            int i;
            for (i = 1; i <= array1.Length; i++)
            {
                array1[i-1] = i * i;
                Console.WriteLine(array1[i-1]);
            }
        }
    }
}