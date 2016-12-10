using System;

namespace TheCPlayersGuide
{
    internal class Program
    {
        private static void Main2(string[] args)
        {
            // 128bit C# numeric type decimal for easy money calcs
            decimal number = 1.495m;
            Console.WriteLine(number);
            Console.WriteLine("I’m sorry, Dave.I’m afraid I can’t do that.\n"
                + " This is not  a problem ?? :: " + SummedValues(3));
            var whatTheUserTyped = Console.ReadLine();
            Console.WriteLine(whatTheUserTyped);
            if ("What is your name?".ToUpper().Equals(whatTheUserTyped.ToUpper()))
            {
                Console.WriteLine("Hello! My name is C#");
            }

            bool b = true;
            int i = Convert.ToInt32(b);
            Console.WriteLine(i);
            double d = 3.4;
            float f = Convert.ToSingle(d);
            Console.WriteLine(f);



            // ‘@’ symbol before the text(called a verbatim string literal) 
            // which tells the computer to ignore escape characters in the string
            Console.WriteLine(@"C:\Users\RB\Desktop\MyFile.txt");

            // C# 6.0 introduces a new feature called string interpolation. 
            Console.WriteLine($"Does we need Oxygen to breathe?: {b} " + $" {4 + 5}");
        }


        private static int SummedValues(int x)
        {
            return x == 3 ? SummedValues(x * (x + 1)) : x;
        }
    }
}
