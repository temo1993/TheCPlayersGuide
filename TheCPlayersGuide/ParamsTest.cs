using System;
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
            DoSomething(10, 1, 2, 3, 4, 5);
            DoSomething(1,2,3,4,5);
        }
    }
}
