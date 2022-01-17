using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alexis
{
    internal class Fibonacci
    {
        internal int term1 = 0;
        private int term2 = 1;

        public Fibonacci()
        {
            term1 = 0;
            term2 = 1;
        }
        public Fibonacci(int t1, int t2)
        {
            term1 = t1;
            term2 = t2;
        }

        /// <summary>
        /// renvoie le (n+1)ième terme de la suie de Fibonacci définie lors de l'appel du constructeur de l'objet
        /// </summary>
        /// <param name="n"> 0.. 1.. 2.. n</param>
        /// <returns></returns>
        public int GetNth(int n)
        {
           if (n <= 0)
            {
                return term1;
            }
            if (n == 1)
            {
                return term2;
            }    
            return GetNth(n - 1) + GetNth(n - 2);
        }

        public int GetNthbis(int n)
        {
            if (n == 0)
            {
                return term1;
            }
            if (n == 1)
            {
                return term2;
            }

            int sum = 0;
            int n_2 = term1;
            int n_1 = term2;

            for (int i = 1; i < n; i++)
            {
                sum = n_2 + n_1;
                n_2 = n_1;
                n_1 = sum;
            }
            return sum;
        }
    }

    class T2 : Fibonacci
    {
        public T2()
        {
            base.
        }
    }
}
