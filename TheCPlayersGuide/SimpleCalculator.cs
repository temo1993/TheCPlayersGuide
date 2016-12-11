using System;

namespace TheCPlayersGuide
{
    public class SimpleCalculator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This is demo of simple calculator. version : 0.1beta");
            Console.WriteLine("Please enter first number");
            var userfirstInput = Console.ReadLine();
            int firstNum = Convert.ToInt32(userfirstInput);
            Console.WriteLine("Please enter the second number: ");
            var userSecondInput = Console.ReadLine();
            int secondNum = Convert.ToInt32(userSecondInput);
            Console.WriteLine("Please enter the operation to do: ");
            var userThirdInput = Console.ReadLine();
            if (userThirdInput != null)
            {
                char operation = Convert.ToChar(userThirdInput);
                Console.WriteLine("Here is the answer: ");
                SimpleCalc(firstNum,secondNum,operation);
            }
        }




        private static void SimpleCalc(int firstNum, int secondNum, char operation)
        {
            switch (operation)
            {
                case '+':
                    Console.WriteLine($"{firstNum} {operation} {secondNum} equals {firstNum + secondNum}"); 
                    break;
                case '-':
                    Console.WriteLine($"{firstNum} {operation} {secondNum} equals {firstNum - secondNum}"); 
                    break;
                case '*':
                    Console.WriteLine($"{firstNum} {operation} {secondNum} equals {firstNum * secondNum}"); 
                    break;
                case '/':
                    Console.WriteLine(secondNum != 0 ? $"{firstNum} {operation} {secondNum} equals {firstNum / secondNum}" : "ERROR: Division by ZERO!!!");
                    break;
                case '%':
                    Console.WriteLine($"{firstNum} {operation} {secondNum} equals {firstNum % secondNum}");
                    break;
                case '^':
                    Console.WriteLine($"{firstNum} {operation} {secondNum} equals {Math.Pow(firstNum, secondNum)}");
                    break;
                default : Console.WriteLine($"Unfortunately this calculator does not supports {operation} operator!!!");
                    break;
            }
        }
    }
}