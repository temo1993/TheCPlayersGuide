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
        }
    }
}