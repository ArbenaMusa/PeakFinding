using System;

namespace PeakFinding
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix1 = { { 10, 20, 15 },
                               { 21, 30, 14 },
                               { 7 , 16, 32 } };

            int[,] matrix2 = { { 0, 0, 9, 0, 0, 0, 0},
                               { 0, 0, 0, 0, 0, 0, 0},
                               { 0, 1, 0, 0, 0, 0, 0},
                               { 0, 2, 0, 0, 0, 0, 0},
                               { 0, 3, 0, 0, 0, 0, 0},
                               { 0, 5, 0, 0, 0, 0, 0},
                               { 0, 4, 7, 0, 0, 0, 0} };


            int[,] matrix3 = { { 27, 29, 30, 32, 10, 8 , 10, 10, 20, 21, 20 },
                              {  18, 20, 22, 24, 14, 13, 12, 11, 14, 15, 14 },
                              {  27, 32, 33, 35, 15, 9 , 11, 21, 23, 25, 23 },
                              {  42, 42, 44, 46, 18, 17, 19, 20, 26, 30, 26 } };

            Console.WriteLine($"Peak element in the given matrix is : {PeakFinder.FindPeak(matrix3)}");
        }

    }
}
