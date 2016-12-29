using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCPlayersGuide
{
    class MathDelegateMain
    {
        public static void Main(string[] args)
        {
            MathDelegate mathOperation = Add;
        }





        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Power(int baseNumber, int exponent)
        {
        return (int)Math.Pow(baseNumber, exponent);
        }
    }
}
