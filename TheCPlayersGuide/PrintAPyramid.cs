using System;

namespace TheCPlayersGuide
{
    public class PrintAPyramid
    {
        public static void Main_(string[] args)
        {
            for (int i = 0; i < 23; i++)
            {
                DrawPyramid(2+i, 3+i*2);
            }
        }


        private static void DrawPyramid(int height, int width)
        {
            string c = "*";
            string space = " ";
            for (var i = 0; i < height; i++)
            {
                for (var j = i; j < width/2; j++)
                {
                    Console.Write(space);
                }               
                    Console.Write(c);                                   
                Console.WriteLine();
                c += "**";
            }
        }
    }
}