using System.Collections.Generic;
using System.Linq;

namespace TheCPlayersGuide
{
    internal class LambdaExample
    {
        public static void Main_(string[] args)
        {
            List<int> numbers = new List<int> { 1, 7, 4, 2, 5, 3, 9, 8, 6 };
            IEnumerable<int> evenNumbers = numbers.Where(IsEven);
            numbers.Where(delegate (int number) { return (number % 2 == 0); }); // Anonymous Method
            IEnumerable<int> evens = numbers.Where(x => x % 2 == 0);

        }

        // These two private instance variables used by the methods below.
        private int x;
        private int[] internalNumbers = new int[] { 1, 2, 3 };
        // Property (read-only, no setter allowed)
        public int X => x;
        // Operator overload
        public static int operator +(LambdaExample a, LambdaExample b) => a.X + b.X;
        // Indexer
        public int this[int index] => internalNumbers[index];
        // Normal method
        public int ComputeSquare(int value) => value * value;

        private static List<int> FindEvenNumbers(List<int> numbers)
        {
            List<int> onlyEvens = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 == 0) // checks if it is even using mod operator
                    onlyEvens.Add(number);
            }
            return onlyEvens;
        }

        private static bool IsEven(int number)
        {
            return (number % 2 == 0);
        }
    }
}