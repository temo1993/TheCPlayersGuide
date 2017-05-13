using System;
using System.Collections.Generic;
using System.Threading;

namespace TheCPlayersGuide
{
    public class FrogRacing
    {
        public static void Main_(string[] args)
        {
            int totalFrogs = 5;

            List<Thread> threads = new List<Thread>();

            for (int index = 0; index < totalFrogs; index++)
            {
                Thread thread = new Thread(HandleSingleFrog);
                thread.Start(index + 1);
                threads.Add(thread);
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            Console.WriteLine("The race is over!");
            Console.ReadKey();
        }

        private static Random random = new Random();

        private static void HandleSingleFrog(object numberAsObject)
        {
            int number = (int)numberAsObject;

            for (int jump = 0; jump < 10; jump++)
            {
                Console.WriteLine("Frog " + number + " jumped.");
                Thread.Sleep(random.Next(5000) + 500);
            }

            Console.WriteLine("***Frog " + number + " is finished!***");
        }
    }
}