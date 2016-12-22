using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace TheCPlayersGuide
{
    class PropertiesTest
    {
        public static void Main(string[] args)
        {
            // Using properties to create objects without need of constructor overloadings.
            // Whats the great feature!
            Book cPlayersGuide = new Book()
            {
                Author = "RB Whitaker", Language = "English", PaperBack = 368,
                Price = 24.97m, Publisher = "Starbound Software",
                Title = "The C# Players Guide 2nd Edition", Date = new DateTime(2015, 9, 22)
            };
        }
    }

    class Book
    {
        private string title;
        private string author;
        private DateTime date;
        private decimal price;
        private ushort paperBack;
        private string publisher;
        private string language;


        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public ushort PaperBack { get; set; }
        public string Publisher { get; set; }
        public string Language { get; set; } = "English";
    }
}
