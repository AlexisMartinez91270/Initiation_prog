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
            int[] array1 = new int[] { 2, 5, 3, 10, 4, 2 };
            int i, j;
            for (i = 1; i <= 6; i++)
            {
                Console.WriteLine(array1[i - 1]);
                array1[i-1] *= array1[i - 1];                
            }

            for (j = 1; j <= 3; j++)
            {
                Console.WriteLine(array1[j - 1]);
            }

            for (j = 4; j <=6; j++)
            {
                Console.WriteLine((array1[j - 1]) * 2);
            }
        }
    }
}