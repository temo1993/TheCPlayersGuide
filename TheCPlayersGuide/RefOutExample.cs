using System;

namespace TheCPlayersGuide
{
    public class RefOutExample
    {
        public static void Main_(string[] args)
        {
            int a = 1;
            int b = 2;

            RefOutExample xx = new RefOutExample();
            Console.WriteLine($"a is {a}, b is {b}");
            xx.InitAB(ref a, out b);
            Console.WriteLine($"a is {a}, b is {b}");
        }


        /*
         With the ref keyword, 
         the calling method needs to initialize the variable before the method call. This allows the
         called method to assume that it is already initialized. These are sometimes called reference
         parameters.
         */
        /*
         With the out keyword, 
         the compiler ensures that the called method initializes the variable before
         returning from the method. These are sometimes called output parameters.
         */
        private void InitAB(ref int x, out int y)
        {
            x = 3;
            y = 17;
        }
    }
}