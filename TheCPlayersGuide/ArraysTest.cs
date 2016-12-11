using System;

namespace TheCPlayersGuide
{
    public class ArraysTest
    {
        public static void Main_(string[] args)
        {
            /* Multi-dimensional Array*/
            /* When each array within a larger array has a different length, 
             * it is called a jagged array.If they’re all the same length,
             * it is often called a square array or a rectangular array.*/
            int[][] matrix = new int[4][];
            matrix[0] = new int[4];
            matrix[1] = new int[5];
            matrix[2] = new int[2];
            matrix[3] = new int[6];
            matrix[2][1] = 7;
            



            int[,] matrix2 = new int[4, 4];
            matrix2[0, 0] = 1;
            matrix2[0, 1] = 0;
            matrix2[3, 3] = 1;


            /*int[][] matrix3 = new int[4][];
            matrix3[0] = new int[2];
            matrix3[1] = new int[6];
            // Continue filling in values for the jagged array...
            for (int row = 0; row < matrix3.Length; row++)
            {
                for (int column = 0; column < matrix3[row].Length; column++)
                {
                    Console.Write(matrix3[row][column] + " "); // Each item in the row separated by spaces
                }
                Console.WriteLine(); // Rows separated by lines
            }*/




            int[,] matrix4 = new int[4, 4];
            // Fill in contents for multi-dimensional array
            // Note: GetLength gives back the size of the multi-dimensional array for a specific index.
            for (int row = 0; row < matrix4.GetLength(0); row++)
            {
                for (int column = 0; column < matrix4.GetLength(1); column++)
                {
                    Console.Write(matrix4[row, column] + " ");
                }
                Console.WriteLine();
            }




            int[] scores = new int[10];
            foreach (int score in scores)
                Console.WriteLine("Someone had this score: " + score);
        } 
    }
}