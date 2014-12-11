using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSquareDifferenceApps
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumOfSquare = 0;
            double squareOfSum = 0;
            int temp = 0;

            for (int i = 1; i <= 100; i++)
            {
                sumOfSquare += Math.Pow(i, 2);

                temp += i;
            }

            squareOfSum = Math.Pow(temp, 2);

            Console.WriteLine("Difference between the sum of the squares of the first one hundred natural numbers and the square of the sum is: " + (squareOfSum - sumOfSquare));
            Console.ReadLine();
        }
    }
}
