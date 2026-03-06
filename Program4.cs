using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float p, r, t, a, ci;

            Console.WriteLine("enter principal amount");
            p = float.Parse(Console.ReadLine());

            Console.WriteLine("enter the rate");
            r = float.Parse(Console.ReadLine());

            Console.WriteLine("enter the time");
            t = float.Parse(Console.ReadLine());

            float a = 1 + r / 100;
            si = a * p;

            Console.WriteLine("compound the interest" + si);
        }
    }
}
