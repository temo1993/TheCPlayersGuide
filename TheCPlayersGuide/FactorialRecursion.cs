using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCPlayersGuide
{
    class FactorialRecursion
    {
        public static void Main_(string[] args)
        {
//            Console.WriteLine(CalcFactorial(2));
//            Console.WriteLine(CalcFibonacci(3));
            for (int i = 1; i < 11; i++)
            {
                Console.Write(CalcFibonacci(i) + " ");
                if (i%10 == 0)
                {
                    Console.WriteLine();
                }
            }
        }


        private static int CalcFactorial(int number)
        {
            // We establish our "base case" here. When we get to this point, we're done.
            if (number == 1)
                return 1;
            return number * CalcFactorial(number - 1);
        }


        private static long CalcFibonacci(long number)
        {
            if (number == 1 || number == 2)
            {
                return 1;
            }
            return CalcFibonacci(number - 1) + CalcFibonacci(number - 2);
        }
    }
}
