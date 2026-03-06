using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, temp, reverse = 0, remainder;
            Console.WriteLine("enter a number : ");
            num = int.Parse(Console.ReadLine());
            temp = num;
            while(temp > 0)
                {
                remainder = temp % 10;
                reverse = reverse * 10 + remainder;
                temp = temp / 10;

            }
            if (num == reverse)
                Console.WriteLine("it is palidrome");
            else
                Console.WriteLine("it is not palidrome");

        }
    }
}
