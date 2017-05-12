using System.Collections.Generic;
using System.Linq;

namespace TheCPlayersGuide
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public List<Person> Children { get; set; }

        static List<Person> allPeople = new List<Person>();
        IEnumerable<Person> adults =
            from person in allPeople
            where person.Age >= 18
            select person;

        // Finds all parents of teenagers.
        IEnumerable<Person> parentsOfTeenagers =
            from person in allPeople
            from child in person.Children
            where child.Age >= 13 && child.Age < 20
            select person;

        IEnumerable<Person> shortestToTallest =
            from person in allPeople
            orderby person.Height
            select person;

        IEnumerable<Person> tallestToShortest =
            from person in allPeople
            orderby person.Height descending
            select person;
    }
}