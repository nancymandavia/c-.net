using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float PI =                                                                                                                                                                                                                                                                                                                                                                                                                                   3.14f;
            Console.WriteLine("enter the radious of circle:");
            float r = float.Parse(Console.ReadLine());

            float a = PI * r * r;
            Console.WriteLine("enter of circle =" + a);
        }
    }
}
