using System;

namespace TheCPlayersGuide
{
    public class WeekDays
    {
        private enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        private enum DaysOfWeek2
        {
            Sunday = 5, Monday = 6, Tuesday = 7, Wednesday = 8,
            Thursday = 9, Friday = 10, Saturday = 11
        };

        public static void Main_(string[] args)
        {
            // Indicate the type, and give it a name.
            var today = DaysOfWeek.Tuesday;

            DaysOfWeek yesterday = DaysOfWeek.Sunday;
            if (yesterday == DaysOfWeek.Sunday)
            {
                Console.WriteLine("Tomorrowa is "  + today);
                // ...
            }


            // Enum is just int starting from 0. So it can be done:
            int dayAsInt = (int)DaysOfWeek.Sunday;
            DaysOfWeek afterTomorrow = (DaysOfWeek)dayAsInt; // Both of these require an explicit cast.
            DaysOfWeek dayOne = (DaysOfWeek)17; // Legal, but a bad idea...
            Console.WriteLine(dayOne);
        }
    }
}