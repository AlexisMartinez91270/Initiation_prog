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
            // 8.5
            int[] tab8_5 = { 1, 3, 25, 67 };
            MaxMin(tab8_5);        
            /*
            // 8.3 Voyelles
            testEstVoyelle();

            // 8.2 TVA
            double prix = 0, articles = 0, tva = 0;

            prix = DemandeBiggerThan0("Prix unitaire HT :", true);

            articles = DemandeBiggerThan0("Nombres articles :", true);

            tva = DemandeBiggerThan0("Taux TVA :", false);

            Console.WriteLine("prix total HT: " + (prix * articles));
            Console.WriteLine("prix total TTC: " + (prix * articles * (1 + tva * 0.01)));
            */

            Console.ReadLine();
        }

        //8.5
        static void MaxMin(int [] tab)
        {
            int max= tab[0];
            int min= tab[0];

            for (int i = 1; i < tab.Length; i++)
            {
                if (tab[i] > max)
                {
                    max = tab[i];
                }
                if (tab[i] < min)
                {
                    min = tab[i];
                }
            }
            int[] max_min = { max, min };
            Console.WriteLine("max : {0} --- min : {1}", max_min[0], max_min[1]);
        }


        //8.2 TVA

        /// <summary>
        /// /Convertit en double la valeur passée sous forme de chaîne
        /// </summary>
        /// <param name="txt">la chaîne à convertire, par ex "1.0" ou "-1e10" </param>
        /// <param name="strict"></param>
        /// <returns></returns>
        static double ConvertitEnDouble(string eu)
        {
            double d;
            try
            {
                d = Convert.ToDouble(eu);
            }
            catch (Exception)
            {
                Console.WriteLine("Vous n'avez pas saisie un nombre");
                return -1;
            }

            return d;
        }

        static double DemandeBiggerThan0(string txt, bool strict)
        {
            double n;
            double mini = strict ? double.Epsilon : 0;
            do
            {
                Console.WriteLine("{0,-20} {1,90}", txt, "taper 'quit' pour sortir");
                string eu = Console.ReadLine();

                if (eu.ToLower() == "quit")
                {
                    Environment.Exit(0);
                }

                n = ConvertitEnDouble(eu);

                if (n < mini)
                {
                    string ou_egal = "";
                    if (!strict) ou_egal = " ou égal";
                    Console.WriteLine("Veuillez saisir un nombre supérieur" + ou_egal + " à zéro");
                }
            } while (n < mini);

            return n;
        }


        // 8.3 Voyelles
        static bool EstVoyelleBof(char c)
        {
            char[] tabVoy = { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < tabVoy.Length; i++)
            {
                if (c == tabVoy[i]) { return true; }
            }
            char[] tabVoyM = { 'A', 'E', 'I', 'O', 'U' };
            for (int i = 0; i < tabVoy.Length; i++)
            {
                if (c == tabVoyM[i]) { return true; }
            }
            return false;
        }
        static bool EstVoyelleMouais(char c)
        {
            char cl = c.ToString().ToLower()[0]; // MOCHE !!!!!

            char[] tabVoy = { 'a', 'e', 'i', 'o', 'u' };
            for (int i = 0; i < tabVoy.Length; i++)
            {
                if (cl == tabVoy[i]) { return true; }
            
            }
            return false;
        }


        static bool EstVoyelleMieux(char c)
        {
            char[] tabVoy = { 'a', 'e', 'i', 'o', 'u', 'A','E','I','O','U' };
            for (int i = 0; i < tabVoy.Length; i++)
            {
                if (c == tabVoy[i]) { return true; }
            }
            return false;
            
        }

        static bool EstVoyelleCool(char c)
        {
            char[] tabVoy = { 'a', 'e', 'i', 'o', 'u'};
            for (int i = 0; i < tabVoy.Length; i++)
            {
                byte charcode = (byte)tabVoy[i];
                char versionMajus = (char) (charcode - 32);
                if (c == tabVoy[i] | c== versionMajus) { return true; }
            }
            return false;

        }

        static bool EstVoyelle(char c)
        {
            string voyelles = "AEIOUY";
            return voyelles.Contains(c) | voyelles.ToLower().Contains(c) ; 

        }

        static void testEstVoyelle() {
            char[] testarray = { 'a', 'e', 'i', 't', 'A', 'E' };
            for (int i = 0; i < testarray.Length; i++) { 
                Console.WriteLine("{0} : {1},",testarray[i], EstVoyelle(testarray[i]));
            }
            Console.ReadLine();
        }
    }
}
