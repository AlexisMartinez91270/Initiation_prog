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
            int[] notes = new int [] {4, 18, 20, 9, 15, 3, 7, 17, 12, 13, 1, 16, 14, 8, 9 ,10, 13, 9, 5, 18};
            int i, n, nSup10 = 0;
            float percent;


            for (i = 0; i < notes.Length; i++)
            {
                n = notes[i];
                if (n > 10)
                {
                    nSup10++;
                }
            }
            percent = (nSup10 * 100 )/i;
            Console.WriteLine(percent);
        }
    }
}