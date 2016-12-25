using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCPlayersGuide
{
    class ParamsTest
    {
        private static void DoSomething(int x, params int[] numbers)
        {
            Console.WriteLine($"This is x : ¦|{x}|¦");
            Console.Write("This is array content : ");
            foreach (var number in numbers)
            {
                 Console.Write($"¦|{number}|¦");
            }
            Console.WriteLine();
        }


        public static void Main_(string[] args)
        {
            DoSomething(1);
            DoSomething(10, new []{1,2,3,4,5});
            DoSomething(1,2,3,4,5);
        }
    }
}
