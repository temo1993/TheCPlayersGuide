using System;

namespace TheCPlayersGuide
{
    public class DieRolling
    {
        public static void Main_(string[] args)
        {
            Console.WriteLine("             Hello");
            Console.WriteLine("This is dice roll value summer");
            Console.WriteLine(InputOutputPrinter());
        }


        private static int DieRolledCalc(int numberOfTimes)
        {
            Random random = new Random();
            int temp = 0;
            for (int i = 0; i < numberOfTimes; i++)
            {
                temp += random.Next(1, 7);
            }
            return temp;
        }

        private static string InputOutputPrinter()
        {
            while (true)
            {
                Console.Write("Please enter times to roll a dice: ");
                Console.WriteLine($"Sumed value is {DieRolledCalc(ReadUserInputInt())}");
                Console.Write("To continue press enter or Quit/Exit to finish the program: ");
                string userInput = ReadUserString();
                if (string.Equals("Quit", userInput, StringComparison.OrdinalIgnoreCase) ||
                    string.Equals("Exit", userInput, StringComparison.OrdinalIgnoreCase))
                {
                    return "Bye, Bye!";
                }
            }
        }

        private static int ReadUserInputInt()
        {
            var userInput = Console.ReadLine();
            return Convert.ToInt32(userInput);
        }

        private static string ReadUserString()
        {
            var userInput = Console.ReadLine();
            return userInput;
        }
    }
}