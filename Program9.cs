using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number :");
            int num = Convert.ToInt32(Console.ReadLine());

            int first = 0, second = 1;
            Console.WriteLine("fibonacci series:");
            while(first <= num)
            {
                Console.Write(first + "");
                int next = first + second;
                first = second;
                second = next;
            }
        }
    }
}
