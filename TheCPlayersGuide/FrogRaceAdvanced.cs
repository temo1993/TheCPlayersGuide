using System;
using System.Collections.Generic;
using System.Threading;

namespace TheCPlayersGuide
{
    internal class FrogRaceAdvanced
    {
        /// <summary>
        /// The total number of jumps required by a frog to finish.
        /// </summary>
        private static readonly int TotalJumps = 10;

        /// <summary>
        /// The total number of frogs in the race.
        /// </summary>
        private static readonly int TotalFrogs = 5;

        /// <summary>
        /// The current jump for each frog in the race.
        /// </summary>
        private static int[] _jumpCount;

        /// <summary>
        /// The finishing place of each frog in the race. A value of 0
        /// means that they haven't finished yet.
        /// </summary>
        private static int[] _finishingPlace;

        /// <summary>
        /// The place that the next frog to finish will take.
        /// </summary>
        private static int _place;

        /// <summary>
        /// A plain old object, used as a lock for accessing shared code.
        /// </summary>
        private static readonly object RaceLock = new object();

        /// <summary>
        /// A shared random number generator, for making the frogs jump
        /// at random intervals.
        /// </summary>
        private static readonly Random Random = new Random();

        /// <summary>
        /// Runs the frog race.
        /// </summary>
        /// <param name="args"></param>
        public static void Main_(string[] args)
        {
            // Set things up.
            _place = 0;
            _finishingPlace = new int[TotalFrogs];
            _jumpCount = new int[TotalFrogs];

            for (int index = 0; index < TotalFrogs; index++)
            {
                _jumpCount[index] = 0;
                _finishingPlace[index] = 0;
            }

            // Draw things at the starting line.
            PrintRace();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to start the race!");

            Console.ReadKey(false);

            // Kick off the race.
            List<Thread> threads = new List<Thread>();
            for (int index = 0; index < TotalFrogs; index++)
            {
                Thread thread = new Thread(HandleSingleFrog);
                thread.Start(index + 1);
                threads.Add(thread);
            }

            // Wait for all of the threads/frogs to finish.
            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            // End the race.
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The race is over!");
            Console.ReadKey();
        }

        /// <summary>
        /// Determines what place a finishing frog took, and assigns it.
        /// The next time this method is called, a different number will
        /// be assigned.
        /// </summary>
        /// <returns></returns>
        private static int GetPlace()
        {
            // We lock on this critical section, because if we don't, it's
            // possible for two frogs to be assigned the same finishing place
            // if a context switch happens at the wrong time.
            lock (RaceLock)
            {
                _place++;
                return _place;
            }
        }

        /// <summary>
        /// Runs the work for a single frog. The frog will periodically
        /// jump until it has jumped as many times as required, at which
        /// point it will finish up and the thread will end.
        /// </summary>
        /// <param name="numberAsObject"></param>
        private static void HandleSingleFrog(object numberAsObject)
        {
            int number = (int)numberAsObject;

            for (int jump = 0; jump < TotalJumps; jump++)
            {
                Thread.Sleep(Random.Next(3000) + 500);
                _jumpCount[number - 1]++;
                PrintRace(); // Whenever a frog moves, we'll redraw.
            }

            // When we're done, we'll figure out what place the frog took.
            _finishingPlace[number - 1] = GetPlace();
            PrintRace();
        }


        private static void PrintRace()
        {
            // It would be bad if we tried to print twice at the same time,
            // so we lock here to protect context switches from occuring right
            // in the middle of this.
            // In theory, it would make sense to use a different lock for this
            // than the one that chooses the frog's finishing place.
            lock (RaceLock)
            {
                Console.Clear();

                // Print the top banner.
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("FROG");
                Console.WriteLine("    RACE!");

                // Print the finishing place (or ?) of each of the frogs.
                Console.ForegroundColor = ConsoleColor.White;
                for (int frog = 0; frog < TotalFrogs; frog++)
                {
                    if (_finishingPlace[frog] > 0)
                    {
                        Console.Write(_finishingPlace[frog] + " ");
                    }
                    else
                    {
                        Console.Write("? ");
                    }
                }

                Console.WriteLine();

                // Print out the race, one row at a time.
                for (int row = 0; row < TotalJumps + 1; row++)
                {
                    for (int frog = 0; frog < TotalFrogs; frog++)
                    {
                        // If this is the row the frog is on, print a frog...
                        if (_jumpCount[frog] == TotalJumps - row)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Ω ");
                        }
                        else // Otherwise, print an empty marker.
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(". ");
                        }
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}