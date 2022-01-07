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
            testEstConvertible();
            /*
                        double eu_invalide = 0;
                        bool strict = true;
                        double prix = 0, articles = 0, tva = 0;

                        do
                        {
                            eu_invalide = Convertit("Prix unitaire HT :", ref prix, strict);
                        } while (eu_invalide == -1);
                        do
                        {
                            eu_invalide = Convertit("Nombres articles :", ref articles, strict);
                        } while (eu_invalide == -1);
                        do
                        {
                            eu_invalide = Convertit("Taux TVA :", ref tva, !strict);
                        } while (eu_invalide == -1);

                        Console.WriteLine("prix total HT: " + (prix * articles));
                        Console.WriteLine("prix total TTC: " + (prix * articles * (1 + tva * 0.01)));
            */
            Console.ReadLine();
        }




        /// <summary>
        /// /Convertit en double la valeur passée sous forme de chaîne
        /// </summary>
        /// <param name="txt">la chaîne à convertire, par ex "1.0" ou "-1e10" </param>
        /// <param name="strict"></param>
        /// <returns></returns>
        static double ConvertitEnDouble(string txt)
        {
            Console.WriteLine(txt);
            string eu = Console.ReadLine();

            double d;
            try
            {
                d = Convert.ToDouble(eu);
            }
            catch (Exception e)
            {
                Console.WriteLine("Vous n'avez pas saisie un nombre");
                return -1;
            }
            double convert_numb = d;

            return convert_numb;
        }

        static bool EstConvertible(string s, ref double resultat)
        {
            double d;
            try
            {
                d = Convert.ToDouble(s);
            }
            catch (Exception e)
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
        static bool IsBiggerThan0(float n, bool strict)
        {
            if (strict) return n >= float.Epsilon;
            if (Math.Abs(n) < float.Epsilon) return true;
            return IsBiggerThan0(n, true);
        }

        static void testEstConvertible()
        {
            double r = 0;
            string[] testValues = { "1,2", "1", "sska", "1.9" };
            Console.WriteLine("départ test:");
            Console.WriteLine(" Valeur à tester - Résultat");
            Console.WriteLine(" -----------------------------------------------------------------");
            for (int i = 0; i < testValues.Length; i++) {
                Console.WriteLine(" Valeur: {0,16}    - Résultat: {1}", 
                    testValues[i], 
                    EstConvertible(testValues[i], ref r)
                    ) ;
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

    }
}
