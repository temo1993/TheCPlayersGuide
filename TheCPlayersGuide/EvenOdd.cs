using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCPlayersGuide
{
    class EvenOdd
    {
        public static void Main_()
        {
            Console.WriteLine("Hello, World!");
            short a = 30000;
            short b = 30000;
            short sum = (short)(a + b);
            Console.WriteLine(sum);
            Console.WriteLine($"short's max value is - {short.MaxValue}");
            Console.WriteLine($"short's min value is - {short.MinValue}");
            EvenOddCalc(60);
        }


        private static void EvenOddCalc(int number)
        {
            Console.WriteLine(number%2 == 0 ? $"{number} is Even" : $"{number} is Odd");
        }
    }
}
