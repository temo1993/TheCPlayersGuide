using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCPlayersGuide
{
    class PositiveNegative
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This is sign checker v0.1beta");
            Console.WriteLine("Please enter first number : ");
            var firstUserInput = Console.ReadLine();
            var firstNum = Convert.ToInt32(firstUserInput);
            Console.WriteLine("Please enter second number : ");
            var secondUserInput = Console.ReadLine();
            var secondNum = Convert.ToInt32(secondUserInput);
            ComputeSign(firstNum,secondNum);
        }

        private static void ComputeSign(int first, int second)
        {
            try
            {
                if (first < 0 && second > 0 || first > 0 && second < 0)
                {
                    Console.WriteLine("Sign should be negative!!!");
                }
                else if (first < 0 && second < 0)
                {
                    Console.WriteLine("Sign should be positive!!!");
                }
                else if (first == 0 || second == 0)
                {
                    Console.WriteLine("Multiplication answer will be Zero!!!");
                }
                else
                {
                    Console.WriteLine("Sign should be positive!!!");
                }
            }
            catch (FormatException ae)
            {
                Console.WriteLine("There is some problem!!! - " + ae.Message);
            }
            finally
            {
                Console.WriteLine("Program terminated without any error!!!");
            }
        }
    }
}
