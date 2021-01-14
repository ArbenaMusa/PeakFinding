using System;

namespace PeakFinding
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            int[,] matrix = {{  27, 29, 30, 32, 10, 8 , 10, 10, 20, 21 ,20 },
                                         {  18, 20, 22, 24, 14, 13, 12, 11, 14, 15 ,14 },
                                         {  27, 32, 33, 35, 15, 9 , 11, 21, 23, 25 ,23 },
                                         {  32, 40, 44, 41, 18, 17, 19, 20, 26, 30 ,26 } };*/

            int[,] matrix = {
                              { 10, 20, 15 },
                              { 21, 30, 14 },
                              { 7 , 16, 32 } 
                            };


            // Number of rows and columns 
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            Console.WriteLine($"Peak element in the given matrix is : {PeakFinder.FindPeak(matrix, rows, columns, columns / 2)}");
        }

    }
}
