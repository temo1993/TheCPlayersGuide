using System;

namespace TheCPlayersGuide
{
    public class MonthsEnum
    {
        private enum Months
        {
            January = 1, February = 2, March = 3, April = 4 , May = 5,
            June = 6, July = 7, August = 8, September = 9,
            October = 10, November = 11, December = 12
        }


        public static void Main_(string[] args)
        {
            Console.WriteLine("This is month viewer app");
            Console.WriteLine("Please enter a number of month");
            var input = Console.ReadLine();
            int userInput = Convert.ToInt32(input);
            if (userInput >= 1 && userInput <= 12)
            {
                Months userEnteredMonth = (Months)userInput;
                Console.WriteLine($"This is number for month ::: {userEnteredMonth}");
            }
            else
            {
                Console.WriteLine("Please enter numbers from 1 to 12!!!");
            }
        }
    }
}