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
            int[] array1 = new int[8];
            int i;

            array1[0] = 1;
            array1[1] = 1;

            for (i = 2; i < array1.Length; i++)
            {
                array1[i] = array1[i-1] + array1[i - 2];               
            }

            for (i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }
        }
    }
}