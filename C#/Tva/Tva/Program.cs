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
            double prix = 0, articles = 0, tva = 0;

            prix = DemandeBiggerThan0("Prix unitaire HT :", true);

            articles = DemandeBiggerThan0("Nombres articles :", true);

            tva = DemandeBiggerThan0("Taux TVA :", false);

            Console.WriteLine("prix total HT: " + (prix * articles));
            Console.WriteLine("prix total TTC: " + (prix * articles * (1 + tva * 0.01)));

            /*Console.ReadLine();*/
        }




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

        /// <summary>
        /// Test si l'entrée utilisateur peut etre convertit en double ou pas
        /// </summary>
        /// <param name="s">la chaîne à convertire, par ex "1.0" ou "-1e10" </param>
        /// <param name="resultat">Stockage du résultat de la convertion </param>
        /// <returns></returns>
        static bool EstConvertible(string s, ref double resultat)
        {
            double d;
            try
            {
                d = Convert.ToDouble(s);
            }
            catch (Exception)
            {
                return false;
            }
            resultat = d;
            return true;
        }


        /// <summary>
        /// renvoie true si le float passé en paramètre est supérieur à 0 (strictement ou pas) (utilise float.Epsilon pour la comparaison)
        /// </summary>
        /// <param name="n"></param>
        /// <param name="strict">if strict est false, renvoie également true si le nombre est coonsidéré comme 0</param>
        /// <returns>true si n est considéré positif (ou nul, avec l'option strict à false)</returns>
        static bool IsBiggerThan0(double n, bool strict)
        {
            if (strict) return n >= float.Epsilon;
            if (Math.Abs(n) < float.Epsilon) return true;
            return IsBiggerThan0(n, true);
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

        static void testEstConvertible()
        {
            double r = 0;
            string[] testValues = { "1,2", "1", "sska", "1.9" };
            Console.WriteLine("départ test:");
            Console.WriteLine(" Valeur à tester - Résultat");
            Console.WriteLine(" -----------------------------------------------------------------");
            for (int i = 0; i < testValues.Length; i++)
            {
                Console.WriteLine(" Valeur: {0,16}    - Résultat: {1}",
                    testValues[i],
                    EstConvertible(testValues[i], ref r)
                    );
            }
            Console.WriteLine("fin test\n");

        }

        static void testIsBiggerThan()
        {
            float[] testValues = { 0f, -10.0f, +5f, float.Epsilon, -float.Epsilon };
            Console.WriteLine("départ test:");
            Console.WriteLine(" Valeur à tester - Résultat mode strict - Résultat mode non-strict");
            Console.WriteLine(" -----------------------------------------------------------------");
            for (int i = 0; i < testValues.Length; i++)
            {
                Console.WriteLine(" Valeur: {0,16}    - Résultat strict: {1} - Résultat non-strict {2}",
                    testValues[i],
                    IsBiggerThan0(testValues[i], true),
                    IsBiggerThan0(testValues[i], false)
                    );
            }
            Console.WriteLine("fin test\n");

        }

        static void TestDoubleBiggerThan0()
        {
            string[] testValues = { "1,2", "1", "sska", "1.9", "0", "-1" };
            Console.WriteLine("départ test:");
            Console.WriteLine(" Valeur à tester - Résultat mode strict - Résultat mode non-strict");
            Console.WriteLine(" -----------------------------------------------------------------");
            for (int i = 0; i < testValues.Length; i++)
            {
                Console.WriteLine(" Valeur: {0,16}    - Résultat strict: {1} - Résultat non-strict {2}",
                    testValues[i],
                    DemandeBiggerThan0(testValues[i], true),
                    DemandeBiggerThan0(testValues[i], false)
                    );
            }
            Console.WriteLine("fin test\n");

        }
    }
}