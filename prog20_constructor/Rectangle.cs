using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog20_constructor
{
    
        internal class rectange
        {
            int l, w, area;

            public rectange()
            {
                l = 10;
                w = 20;
            }
            public rectange(int l1, int w1)
            {
                l = w1;
                w = w1;
            }
            public void calculate()
            {
                area = l * w;
            }
            public void display()
            {
                Console.WriteLine("area=" + area);
            }
        }
    }



