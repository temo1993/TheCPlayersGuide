using System;

namespace TheCPlayersGuide
{
    class PropertiesTest
    {
        public static void Main_(string[] args)
        {
            // object initializer syntax
            // Using properties to create objects without need of constructor overloadings.
            // Whats the great feature!
            Book cPlayersGuide = new Book()
            {
                Author = "RB Whitaker", Language = "English", PaperBack = 368,
                Price = 24.97m, Publisher = "Starbound Software",
                Title = "The C# Players Guide 2nd Edition", Date = new DateTime(2015, 9, 22)
            };
            
            Book anotherBook = new Book()
            {
                Author = "Me", Language = "Geo", PaperBack = 121, Date = new DateTime(2017, 4, 26),
                Price = 0.50m, Publisher = "HomeBook", Title = "C# for Java Developers"
            };
            Console.WriteLine(cPlayersGuide.Author);
            Console.WriteLine(anotherBook.Title);
        }
    }

    class Book
    {
        public Book()
        {
        }

        public Book(int reviewScore)
        {
            ReviewScore = reviewScore;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public ushort PaperBack { get; set; }
        public string Publisher { get; set; }
        public string Language { get; set; } = "English";

        public int ReviewScore { get; }

}
}
