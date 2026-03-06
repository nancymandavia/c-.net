using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());

            bool isprime = true;

            if (num <= 1)
            {
                isprime = false;

            }
            else
            {
                {
                     for (int i = 2; i <= num/2; i++)
                    {
                        if(num % i == 0)
                        {
                            isprime = false;
                            break;
                        }
                    }
                }
                if (isprime)
                    Console.WriteLine("it is a prime number");
                else
                    Console.WriteLine("it is not a pime number");
            }
        }
    }
}
