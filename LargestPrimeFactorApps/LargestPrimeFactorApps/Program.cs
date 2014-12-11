using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPrimeFactorApps
{
    class Program
    {
        static void Main(string[] args)
        {
            long i = 0, prime = 0;
            long large = 600851475143;
            //large = Convert.ToUInt32(Console.ReadLine());

            for (i = 2; i<=large-1; i++)
            {
                if (large % i == 0)
                prime = i;
                
            }
           

            Console.WriteLine(prime);
            Console.ReadKey();
        }
    }
}
