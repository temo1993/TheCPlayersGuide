using System;

namespace TheCPlayersGuide
{
    public class ExceptionsTest
    {
        public static void Main_(string[] args)
        {
            Console.WriteLine(GetNumberFromUser());
            try
            {
                var ateTooManyHamburgersException = new AteTooManyHamburgersException(25);
                Console.WriteLine(ateTooManyHamburgersException);
                ateTooManyHamburgersException.HamburgersEaten = 125;
                Console.WriteLine(ateTooManyHamburgersException);
            }
            catch (AteTooManyHamburgersException e)
            {
                Console.WriteLine($"{e.HamburgersEaten} is too many hamburgers.");
            }
        }


        private static int GetNumberFromUser()
        {
            int usersNumber = 0;
            while (usersNumber < 1 || usersNumber > 10)
            {
                try
                {
                    Console.Write("Enter a number between 1 and 10: ");
                    string usersResponse = Console.ReadLine();
                    usersNumber = Convert.ToInt32(usersResponse);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("You must enter a number." + e.Message);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Enter a smaller number." + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("An unknown error occured." + e.Message);
                }
            }
            return usersNumber;
        }

        public void CauseTrouble() // Always up to no good...
        {
            throw new Exception("Just doing my job!");
        }

        // For all of you on the other side of the pond, if it makes you feel any better, you
        // can still call them "beef burgers".
        private class AteTooManyHamburgersException : Exception
        {
            public int HamburgersEaten { get; set; }
            public AteTooManyHamburgersException(int hamburgersEaten)
            {
                HamburgersEaten = hamburgersEaten;
            }
        }
    }
}