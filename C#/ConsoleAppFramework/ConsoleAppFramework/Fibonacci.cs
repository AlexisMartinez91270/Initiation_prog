using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alexis
{
    internal class Fibonacci
    {
        int term1 = 0;
        int term2 = 1;
        public Fibonacci(int t1, int t2)
        {
            term1 = t1;
            term2 = t2;
        }

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
}
