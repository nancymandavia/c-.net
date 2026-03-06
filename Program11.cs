using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)

            {
                if (i < 2)
                    continue;
                bool isprime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if(i % j == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime) Console.Write(i + "");
            }
        }
    }
}
