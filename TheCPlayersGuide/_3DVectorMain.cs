using System;

namespace TheCPlayersGuide
{
    public class _3DVectorMain
    {
        static void Main_(string[] args)
        {
            _3DVector v1 = new _3DVector(1, 2, 3);
            _3DVector v2 = new _3DVector(3, 3, 3);
            Console.WriteLine(v1 + v2);
            Console.WriteLine(v1 - v2);

            _3DVector v = new _3DVector(2, 0, -4);
            Console.WriteLine(-v);

            Console.WriteLine(v1 * 4);
            Console.WriteLine(new _3DVector(2, 4, 6) / 2);

            Console.ReadKey();


            _3DVector vector = new _3DVector(5, 2, 2);
            double xComponent = vector[0]; // Use indexing to set the x variable.
            double yComponent = vector[1]; // Use indexing to set the y variable.
            double zComponent = vector[2]; // Use indexing to set the z variable.

            _3DVector vector2 = new _3DVector(5, 2, 2);
            double xComponent2 = vector2["x"]; // Indexing operator with strings.
            double yComponent2 = vector2["y"]; 
            double zComponent2 = vector2["z"]; 
        }
    }
}