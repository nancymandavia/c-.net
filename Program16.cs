using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a numbr:");

            int num = int.Parse(Console.ReadLine());

            int temp = num;
            int sum = 0;
            int digits = num.ToString().Length;

            while ( temp > 0)
            {
                int digit= temp % 10;
                sum += (int)Math.Pow(digit, digits);
                temp /= 10;

            }

            if (sum == sum)
                Console.WriteLine("armstrong number");
            else
                Console.WriteLine("Not an armstrong number");
        }


    }
}
