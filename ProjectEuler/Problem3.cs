using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem3
    {
        long largestPrimeFactor = 0;
        long num = 600851475143;

        public Problem3()
        {
            //We don't need to test beyond the square root
            for (long i = 1; i < Math.Sqrt(num); i++)
            {
                //Don't test even numbers beyond 2
                if (i > 2 && i % 2 != 0)
                {
                    if (num % i == 0)
                    {
                        if (Utilities.IsPrime(i))
                        {
                            largestPrimeFactor = i;
                        }
                    }
                }
            }

            Console.WriteLine("Largest prime factor of 600851475143 is: " + largestPrimeFactor);
        }
    }
}
