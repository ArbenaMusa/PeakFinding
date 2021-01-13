using System;

namespace PeakFinding
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[,] matrix = {{ 10, 8, 10, 10 },
                                      { 14, 13, 12, 11 },
                                      { 15, 9, 11, 21 },
                                      { 16, 17, 19, 20 }};*/

            int[,] matrix = { { 10, 20, 15 },
                            {21, 30, 14},
                            {7,  16, 32 } };


            // Number of rows and columns 
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            Console.WriteLine($"Peak element in the given matrix is : {PeakFinder.FindPeak(matrix, rows, columns, columns / 2)}");
        }
    }
}
