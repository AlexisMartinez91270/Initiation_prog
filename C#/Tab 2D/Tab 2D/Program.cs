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
            int maxLength = 4;
            float[,] myTab = InitTab();

            WriteTabLigne(myTab, maxLength);

            Console.WriteLine("\n");

            WriteTabColonne(myTab, maxLength);

            Console.ReadLine();
        }

        static float[,] InitTab()
        {
            // Initialisation nombres élèves et notes
            Console.WriteLine("Sélectionner le nombre d'élève :");
            int nbEleve = int.Parse(Console.ReadLine());
            Console.WriteLine("Sélectionner le nombre de notes :");
            int nbNotes = int.Parse(Console.ReadLine());

            //Création du tableau
            float[,] tab = new float[nbEleve, nbNotes];
            int i, j, val = 1;
            for (i = 0; i < tab.GetLength(0); i++)
            {
                Console.WriteLine("Sélectionner les notes de l'élève {0} :", i + 1);
                for (j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j] = float.Parse(Console.ReadLine());
                }
            }
            return tab;
        }

        static void WriteTabLigne(float[,] tab, int maxLength)
        {
            int i, j;
            for (i = 0; i < tab.GetLength(0); i++)
            {
                // Création des lignes de séparation
                Console.Write("        ");
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
                Console.Write("Elève {0} ", i);
                for (j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write("| {0," + maxLength + "} ", tab[i, j]);
                }
                Console.WriteLine("|");
            }

            // Création de la ligne de fin
            Console.Write("        ");
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

        static void WriteTabColonne(float[,] tab, int maxLength)
        {
            int i, j;
            for (i = 0; i < tab.GetLength(1); i++)
            {
                // Création des lignes de séparation
                Console.Write("      ");
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
                Console.Write("Note {0} ", i);
                for (j = 0; j < tab.GetLength(0); j++)
                {
                    Console.Write("| {0," + maxLength + "} ", tab[j, i]);
                }
                Console.WriteLine("|");
            }

            // Création de la ligne de fin
            Console.Write("      ");
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
