using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Problem1
    {
        public Problem1()
        {
            int sum = 0;

            for(int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                }
                else if (i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
