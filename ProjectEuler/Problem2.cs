using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem2
    {
        int sum = 0;

        int term1 = 1;
        int term2 = 2;

        public Problem2()
        {
            while(term1 < 4000000)
            {
                if(term1 % 2 == 0)
                {
                    sum += term1;
                }

                int term3 = term1 + term2;
                term1 = term2;
                term2 = term3;
            }

            Console.WriteLine(sum);
        }

    }
}
