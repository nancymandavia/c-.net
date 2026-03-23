using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog20_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rectange r1 = new rectange();


            r1.calculate();
            r1.display();
            rectange r2 = new rectange();

            r2.calculate();
            r2.display();
        }
    }
}
