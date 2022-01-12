using System;
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
            int[,] myTab = InitTab();
            int[][] tab2 = { new int []{1,2}, new int []{2,7,9} };


            WriteTabLigne(myTab);

            Console.WriteLine("\n");

            WriteTabColonne(myTab);

            Console.ReadLine();
        }

        static int[,] InitTab()
        {
            int[,] tab = new int[2, 3];
            int i, j, val = 1;
            for (i = 0; i < tab.GetLength(0); i++)
            {
                Console.WriteLine("Sélectionner les notes de l'élève {0} :", i+1);
                for (j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return tab;
        }

        static void WriteTabLigne (int [,] tab)
        {
            int maxLength = 20;
            int i, j;
            for (i = 0; i < tab.GetLength(0); i++)
            {
                // Création des lignes de séparation
                for (j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write("+--");
                    for (int k = 0; k < maxLength; k++)
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine("+");

                // Création des données
                for (j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write("| {0," + maxLength + "} ", tab[i, j]);                    
                }
                Console.WriteLine("|");
            }

            // Création de la ligne de fin
            for (j = 0; j < tab.GetLength(1); j++)
            {
                Console.Write("+--");
                for (int k = 0; k < maxLength; k++)
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine("+");
        }

        static void WriteTabColonne(int[,] tab)
        {
            int maxLength = 20;
            int i, j;
            for (i = 0; i < tab.GetLength(1); i++)
            {
                // Création des lignes de séparation
                for (j = 0; j < tab.GetLength(0); j++)
                {
                    Console.Write("+--");
                    for (int k = 0; k < maxLength; k++)
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine("+");

                // Création des données
                for (j = 0; j < tab.GetLength(0); j++)
                {
                    Console.Write("| {0," + maxLength + "} ", tab[j, i]);
                }
                Console.WriteLine("|");
            }

            // Création de la ligne de fin
            for (j = 0; j < tab.GetLength(0); j++)
            {
                Console.Write("+--");
                for (int k = 0; k < maxLength; k++)
                {
                    Console.Write("-");
                }
            }
            Console.WriteLine("+");
        }
    }
}
