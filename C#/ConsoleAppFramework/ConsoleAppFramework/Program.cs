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
            Console.WriteLine("Entrez un caractère : ");
            string c = Console.ReadLine();
            bool voyelle = ContientVoyelle(c);
            Console.WriteLine(voyelle);
            Console.ReadLine();
        }

        static bool ContientVoyelle(string c)
        {
            string[] voyelles = { "a", "e", "i", "o", "u", "y" };
            for (int i = 0; i < voyelles.Length; i++)
            {
                if (voyelles[i] == c)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
