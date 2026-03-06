using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace program15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str, reverse = " ";

            Console.WriteLine("enter a string : ");
            str = Console.ReadLine();

            for (int i  = str.Length - 1; i >=0; i--)
            {
                reverse += str[i];
               
            }
            if (str == reverse)
                Console.WriteLine("it is palidrome");
            else
                Console.WriteLine("it is not palidrome");
        }
    }
}
