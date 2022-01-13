using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFramework
{
    enum algoVoyelle { aucun, simple, cool, mieux, mouais, bof }
    internal class Program
    {
        static void Main(string[] args)

        {
            var timer = new Stopwatch();
            foreach (algoVoyelle m in Enum.GetValues(typeof(algoVoyelle)))
            {
                 
                /*timer.Start();*/
                timer.Restart();
                //B: Run stuff you want timed
                testEstVoyelle(false, 100_000, m);
                timer.Stop();


                TimeSpan timeTaken = timer.Elapsed;
                Console.WriteLine("{1} :: Time taken: {0} " , timeTaken.ToString(@"m\:ss\.fff"),m.ToString());
                
            }
            /*
            // 8.5 Max Min
            int[] tab8_5 = { 1, 3, 25, 67 };
            MaxMin(tab8_5);        
            
            // 8.3 Voyelles
            

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
        // 8.6 Tri
        //8.5 Max Min
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
            char[] tabVoy = { 'a', 'e', 'i', 'o', 'u', 'y' };
            for (int i = 0; i < tabVoy.Length; i++)
            {
                if (c == tabVoy[i]) { return true; }
            }
            char[] tabVoyM = { 'A', 'E', 'I', 'O', 'U', 'Y' };
            for (int i = 0; i < tabVoy.Length; i++)
            {
                if (c == tabVoyM[i]) { return true; }
            }
            return false;
        }
        static bool EstVoyelleMouais(char c)
        {
            char cl = c.ToString().ToLower()[0]; // MOCHE !!!!!

            char[] tabVoy = { 'a', 'e', 'i', 'o', 'u', 'y' };
            for (int i = 0; i < tabVoy.Length; i++)
            {
                if (cl == tabVoy[i]) { return true; }
            
            }
            return false;
        }


        static bool EstVoyelleMieux(char c)
        {
            char[] tabVoy = { 'a', 'e', 'i', 'o', 'u', 'y', 'A','E','I','O','U', 'Y' };
            for (int i = 0; i < tabVoy.Length; i++)
            {
                if (c == tabVoy[i]) { return true; }
            }
            return false;
            
        }

        static bool EstVoyelleCool(char c)
        {
            char[] tabVoy = { 'a', 'e', 'i', 'o', 'u', 'y'};
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
            string voyelles = "AEIOUYaeiouy";
            return voyelles.Contains(c); 

        }

        static void testEstVoyelle(bool afficher, int nb_repete, algoVoyelle mode) {            
            string s = "aeoihdNJHA"; bool temp=false;
            char[] testarray = s.ToCharArray();
            for (int j = 0; j<nb_repete; j++)
            {
                for (int i = 0; i < testarray.Length; i++)
                {

                   


                    switch (mode)
                    {
                        case algoVoyelle.aucun:
                            
                            break;
                        case algoVoyelle.mouais:
                            temp = EstVoyelleMouais(testarray[i]);
                            break;
                        case algoVoyelle.mieux: temp = EstVoyelleMieux(testarray[i]); break;
                        case algoVoyelle.bof: temp = EstVoyelleBof(testarray[i]); break;
                        case algoVoyelle.cool: temp = EstVoyelleCool(testarray[i]); break;
                        case algoVoyelle.simple: temp = EstVoyelle(testarray[i]); break;
                        default:
                            throw new Exception("Algo non reconnu");


                    }
                    
                    if (afficher)
                    {
                        Console.WriteLine("{0} : {1},", testarray[i], temp);
                    }
                }
            }
            
           
        }
    }
}
