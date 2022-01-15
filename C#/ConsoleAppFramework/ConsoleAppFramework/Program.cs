using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alexis;

namespace ConsoleAppFramework
{
    // Test temps 8.3 Voyelles
    enum algoVoyelle { aucun, simple, cool, mieux, mouais, bof }

    internal class Program
    {
        
        static void Main(string[] args)

        {
            //9.3 Carac
            Carac c1 = new Carac('e');
            Console.WriteLine(c1.EstVoyelle());

            Carac c2 = new Carac('j');
            Console.WriteLine(c2.EstVoyelle());

            Carac c3 = new Carac('A');
            Console.WriteLine(c3.EstVoyelle());

            Carac c4 = new Carac();
            Console.WriteLine(c4.EstVoyelle());
            /*
            Fibonacci f = new Fibonacci(2, 5);
            Console.WriteLine("Entrez entier");
            int nb = int.Parse(Console.ReadLine());
            Console.WriteLine("V1 : Le {0}ième terme vaut : {1}", nb+1, f.GetNth(nb));
            Console.WriteLine("V2 : Le {0}ième terme vaut : {1}", nb+1, f.GetNthbis(nb));
            
            //9.2 Point(fixeAbs/Ord, vlaAbs/Ord)
            Point myPoint = new Point();
            myPoint.FixeAbs(3);
            myPoint.FixeOrd(4);
            Console.WriteLine(myPoint.ValeursAbs());
            Console.WriteLine(myPoint.ValeursOrd());
            

            //9.1 Point(init, deplace, premQuad)
            Point myPoint = new Point();
            myPoint.InitPoint(2, 7);
            myPoint.AffichePoint();
            Console.WriteLine(myPoint.PremQuad());

            myPoint.DeplacePoint(4, -8);
            myPoint.AffichePoint();
            Console.WriteLine(myPoint.PremQuad());

            
            // 8.6 Tri
            int[] myTab = InitTab();
            Console.WriteLine("\n--------------------Tri à bulle--------------------------\n");
            Console.WriteLine("\n--------------------Croissant--------------------------\n");
            int[] myTabTriCroissant = TriTab(myTab, true);
            AfficheTab(myTabTriCroissant, true);

            Console.WriteLine("\n\n--------------------Décroissant--------------------------\n");
            int[] myTabTriDecroissant = TriTab(myTab, false);
            AfficheTab(myTabTriDecroissant, false);                        
            
            // 8.5 Max Min
            int[] tab8_5 = { 1, 3, 25, 67 };
            MaxMin(tab8_5);
            
            // Test temps 8.3 Voyelles
            var timer = new Stopwatch();
            foreach (algoVoyelle m in Enum.GetValues(typeof(algoVoyelle)))
            {
                timer.Restart();
                //B: Run stuff you want timed
                testEstVoyelle(false, 100_000, m);
                timer.Stop();


                TimeSpan timeTaken = timer.Elapsed;
                Console.WriteLine("{1} :: Time taken: {0} " , timeTaken.ToString(@"m\:ss\.fff"),m.ToString());
            }

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
        static int[] InitTab()
        { int[] tab = { 32, 15, 45, 85, 98, 56, 23, 5, 0, -1, 8 };      
            /*Console.WriteLine("Choisisez le nombre de valeurs du tableau :");
            int nbValTab = int.Parse(Console.ReadLine());
            int[] tab = new int[nbValTab];
            Console.WriteLine("Entrez {0} valeurs : ", nbValTab);
            for (int i = 0; i < nbValTab; i++)
            {
                tab[i] = int.Parse(Console.ReadLine());
            }*/
            return tab;
        }
        static int[] TriTab(int[] tab, bool croissant)
        {
            int temp;
            for (int i = 0; i < tab.Length -1; i++)
            {
                Console.WriteLine("\nTableau à l'étape {0}", i);
                AfficheTabIntermediaire(tab);
                for (int j = i+1; j < tab.Length; j++)
                {
                    if (croissant)
                    {
                        if (tab[j] < tab[i])
                        {
                            temp = tab[i];
                            tab[i] = tab[j];
                            tab[j] = temp;
                        }
                    }
                    else
                    {
                        if (tab[j] > tab[i])
                        {
                            temp = tab[i];
                            tab[i] = tab[j];
                            tab[j] = temp;
                        }
                    }
                    
                }
            }

            return tab;
        }

        static void AfficheTab(int[] tab, bool croissant)
        {
            string s = croissant ? "croissant" : "décroissant";
            Console.WriteLine("\nTableau final tri {0}", s);
            for (int i = 0;i < tab.Length; i++)
            {
                Console.Write("| {0,3} ", tab[i]);
            }
            Console.WriteLine("|");
        }

        static void AfficheTabIntermediaire(int[] tab)
        {            
            for (int i = 0; i < tab.Length; i++)
            {                
                Console.Write("| {0,3} ", tab[i]);
            }
            Console.WriteLine("|");
        }

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

        // Test temps 8.3 Voyelles
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
    }
    //9.3 Carac
    class Carac
    {
        private char car;

        public Carac(char c)
        {
            car = c;
        }

        public Carac()
        {
            car = ' ';
        }

        public bool EstVoyelle()
        {
            string voyelles = "AEIOUYaeiouy";
            return voyelles.Contains(car);
        }
    }

    //9.1 Point
    class Point
    {
        //9.2 Point(fixeAbs/Ord, vlaAbs/Ord)
        private int abs, ord;

        public void FixeAbs(int x)
        {
            abs = x;
        }
        public void FixeOrd(int y)
        {
            ord = y;
        }

        public int ValeursAbs()
        {
            return abs;
        }

        public int ValeursOrd()
        {
            return ord;
        }

        //9.1 Point(init, deplace, premQuad)
        public void InitPoint(int x, int y)
        {
            abs = x;
            ord = y;
        }

        public void DeplacePoint(int dx, int dy)
        {
            abs += dx;
            ord += dy;
        }

        public bool PremQuad()
        {
            if (abs >= 0 & ord >= 0)
            {
                return true;
            }
            return false;
        }

        public void AffichePoint()
        {
            Console.WriteLine("Je suis un point de coordonnées : {0}, {1}", abs, ord);
        }
    }
}
