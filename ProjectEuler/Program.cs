using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            String c = "ProjectEuler.Problem" + args[0];
            Object o = Activator.CreateInstance("ProjectEuler", c);
        }
    }
}
