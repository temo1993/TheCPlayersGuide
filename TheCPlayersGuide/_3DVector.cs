using System;

namespace TheCPlayersGuide
{
        /// <summary>
        /// Represents a vector in 3D space, including an x, y,
        /// and z component. This also implements a variety of 
        /// operators, to make it easy to do math with it.
        /// </summary>
        class _3DVector
        {
            /// <summary>
            /// Gets or sets the x component of the vector.
            /// </summary>
            public double X { get; set; }

            /// <summary>
            /// Gets or sets the y component of the vector.
            /// </summary>
            public double Y { get; set; }

            /// <summary>
            /// Gets or sets the z component of the vector.
            /// </summary>
            public double Z { get; set; }

            public _3DVector()
            {
            }

            /// <summary>
            /// Creates a new vector with specific x, y, and z
            /// components.
            /// </summary>
            public _3DVector(double x, double y, double z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            /// <summary>
            /// Adds two vectors together.
            /// </summary>
            public static _3DVector operator +(_3DVector v1, _3DVector v2)
            {
                return new _3DVector(
                    v1.X + v2.X,
                    v1.Y + v2.Y,
                    v1.Z + v2.Z);
            }

            /// <summary>
            /// Subtracts a vector from another one.
            /// </summary>
            public static _3DVector operator -(_3DVector v1, _3DVector v2)
            {
                return new _3DVector(
                    v1.X - v2.X,
                    v1.Y - v2.Y,
                    v1.Z - v2.Z);
            }

            /// <summary>
            /// Negates a vector, so that it is pointing in the opposite
            /// direction.
            /// </summary>
            public static _3DVector operator -(_3DVector v)
            {
                return new _3DVector(-v.X, -v.Y, -v.Z);
            }

            /// <summary>
            /// Multiplies a vector by a scalar.
            /// </summary>
            public static _3DVector operator *(_3DVector v, double scalar)
            {
                return new _3DVector(
                    v.X * scalar,
                    v.Y * scalar,
                    v.Z * scalar);
            }

            /// <summary>
            /// Does division of a vector with a scalar.
            /// </summary>
            public static _3DVector operator /(_3DVector v, double scalar)
            {
                _3DVector vector = null;
                if (!scalar.Equals(0))
                {
                vector = new _3DVector(v.X / scalar, v.Y / scalar, v.Z / scalar);
                }
                else
                Console.WriteLine("scalar has to be more or less than 0!!!");
                return vector;
            }

            /// <summary>
            /// Overridden to make it easy to print out vectors.
            /// This return the vector in the format <x, y, z>
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return "<" + X + ", " + Y + ", " + Z + ">";
            }
        }
    }