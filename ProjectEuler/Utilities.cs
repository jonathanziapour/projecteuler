using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Utilities
    {
        public static bool IsPrime(long n)
        {
            for (long i = 2; i < n; i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
