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
            int n, p;
            //crée les entiers n, p et q
            n = 10;
            //affecte la valeur 10 dans la case mémoire de n
            p = 4;
            //affecte la valeur 5 dans la case mémoire de p
            n = n * p;
            //affecte la valeur de la multiplication de n*p dans la case mémoire de n
            p = n / p;
            //affecte la valeur de la division de n/p dans la case mémoire de n
        }
    }
}
