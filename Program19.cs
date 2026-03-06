using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog19
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[5];
            Console.WriteLine("enter 5 numbers:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write("number" + (i + 1) + ":");

                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int min = numbers[0];
            for (int i = 1; i < 5; i++)
            {

                if (numbers[i] < min)

                {
                    min = numbers[i];
                }
            }
            Console.WriteLine("minimum number is:" + min);
            Console.ReadLine();
        }


            
        
    }
}
