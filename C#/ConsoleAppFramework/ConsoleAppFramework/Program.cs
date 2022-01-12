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
            int [] myTab = InitTab();
            int [] myTabTri = TriCroissant(myTab);
            Console.WriteLine("Tableau trié ----------------------");
            for (int i = 0; i < myTabTri.Length; i++)
            {
                Console.WriteLine(myTabTri[i]);
            }
            Console.ReadLine();
        }

        static int[] TriCroissant(int[] tab)
        {
            int temp;
            for (int i = 0; i < tab.Length - 1; i++)
            {
                for (int j = i + 1; j < tab.Length; j++)
                {
                    if (tab[i] > tab[j])
                    {
                        temp = tab[i];
                        tab[i] = tab[j];
                        tab[j] = temp;
                    }
                }
            }
            return tab;
        }

        static int[] InitTab()
        {
            int[] tab = new int[15];
            Console.WriteLine("Entrez 15 valeurs entières : ");
            for(int i = 0; i < tab.Length; i++)
            {
                tab[i] = int.Parse(Console.ReadLine());
            }
            return tab;
        }
    }
}
