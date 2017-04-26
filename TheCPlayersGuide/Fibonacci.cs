using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCPlayersGuide
{
    class Fibonacci
    {
        public static void Main_(string[] args)
        {
            FibonacciCounter(10,"This is fib num ");

            for (int i = 1; i <= 10; i++)
            {
                FibonacciCounter(i, "This is fib num ");
            }
        }

        /// <summary>
        /// Counts Fibonacci number for the given Index 
        /// </summary>
        /// <param name="fibNumber">Natural number starting from One</param>
        /// <returns>Fibonacci number n = (n - 1) + (n - 2)</returns>
        private static int FibonacciCounter(int fibNumber)
        {
            if (fibNumber <= 0)
            {
               
                throw new StackOverflowException("Please enter natural numbers starting from 1");
            }
            if (fibNumber == 1 || fibNumber == 2)
            {
                return 1;
            }
            return FibonacciCounter(fibNumber - 1) + FibonacciCounter(fibNumber - 2);
        }

        /// <summary>
        /// Counts Fibonacci number for the given Index and prints after the message
        /// </summary>
        /// <param name="fibNumber">Natural number starting from One</param>
        /// <param name="message">Message to print before Fibonacci is displayed. Example "This is Fibonacci "</param>
        /// <returns>Fibonacci number n with optional message ("This is Fibonacci " + n). n = (n - 1) + (n - 2)</returns>
        private static void FibonacciCounter(int fibNumber, string message)
        {
            Console.WriteLine(message + "" + FibonacciCounter(fibNumber));
        }
    }
}
