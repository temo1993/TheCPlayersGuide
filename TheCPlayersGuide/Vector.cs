﻿namespace TheCPlayersGuide
{
    /// <summary>
    /// Class to test operator overloading
    /// </summary>
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector operator +(Vector v, double scalar)
        {
            return new Vector(v.X + scalar, v.Y + scalar);
        }
        public static Vector operator -(Vector v)
        {
            return new Vector(-v.X, -v.Y);
        }
        public static bool operator ==(Vector v1, Vector v2)
        {
            return ((v1.X == v2.X) && (v1.Y == v2.Y));
        }
        public static bool operator !=(Vector v1, Vector v2)
        {
            return !(v1 == v2);
        }
    }
}