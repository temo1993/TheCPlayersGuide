using System;

namespace TheCPlayersGuide
{
    internal class MathDelegateMain
    {
        private const int X = 2;
        private const int Y = 10;
        public static void Main_(string[] args)
        {
            MathDelegate addOperation = Add;
            Console.WriteLine($"This is sum of {X} and {Y} is : {addOperation(X,Y)}");

            MathDelegate substructOperation = Subtract;
            Console.WriteLine($"{X} minus {Y} is : {substructOperation(X,Y)}");

            MathDelegate multiplyOperation = Multiply;
            Console.WriteLine($"{X} multiply on {Y} is : {multiplyOperation(X, Y)}");

            MathDelegateDouble divideOperation = Divide;
            Console.WriteLine($"{X} divide on {Y} is : {divideOperation(X, Y)}");

            MathDelegate powerOperation = Power;
            Console.WriteLine($"{X} in power {Y} is : {powerOperation(X, Y)}");
        }





        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            return a / b;
        }
        public static int Power(int baseNumber, int exponent)
        {
        return (int)Math.Pow(baseNumber, exponent);
        }
    }
}
