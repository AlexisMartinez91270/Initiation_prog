﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFramework
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int [] myTab = InitTab();

            int pmax = FindMax(myTab);

            /* monTypedObjet p= new monTypedObjet();
             p.X = 100;
             testO(p);
             Console.WriteLine(p.X);*/

            string s = string.Format("{0} => {1}", pmax, myTab[pmax]);
            Console.WriteLine(s);
            
            Console.WriteLine("max :{1} à la position :{0} ", pmax, myTab[pmax]);
            Console.ReadLine();
        }

        static int[] InitTab()
        {
            int[] array1 = new int[200];
            array1[64] = 800;
            return array1;
        }

        static int FindMax(int[] tab)
        {
            int i;
            int max = tab[0];
            int maxPos = 0;

            for (i = 1; i < tab.Length; i++)
            {
                if (tab[i] > max)
                {
                    max = tab[i];
                    maxPos = i;
                }
            }
            return maxPos;
        }
        static void testO (monTypedObjet p)
        {
            p.X = 5;
            p = null;
        }


    }

    class monTypedObjet
    {
        public int X;
        public int Y;
    }
}