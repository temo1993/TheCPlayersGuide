using System;

namespace TheCPlayersGuide
{
    internal class Cylinders
    {
        private static void Main3(string[] args)
        {
            // Reading user input
            Console.WriteLine("Please enter a height and radius of cylinder...");
            Console.WriteLine("Height?:");
            String userInputHeight = Console.ReadLine();
            Console.WriteLine("Radius?:");
            String userInputRadius = Console.ReadLine();
            double height = Convert.ToDouble(userInputHeight);
            double radius = Convert.ToDouble(userInputRadius);
            Volume(height, radius);
            SurfaceArea(height, radius);

        }

        private static void Volume(double h, double r)
        {
            Console.WriteLine(" The Volume will be : " + Math.PI * h * r * r);
        }

        private static void SurfaceArea(double h, double r)
        {
            Console.WriteLine(" The surface area will be : " + 2 * Math.PI * r * (r + h));
        }
    }
}
