using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter value of a");
            double value = double.Parse(Console.ReadLine());
            Console.WriteLine("enter value of rate");
            double rate = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the year");
            double year = double.Parse(Console.ReadLine());
            double si = (value + rate + year) / 100;
            Console.WriteLine("simple interest" + si);
            

        }
    }
}
