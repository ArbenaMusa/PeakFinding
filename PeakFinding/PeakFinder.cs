using System;

namespace PeakFinding
{
    public static class PeakFinder
    {
        public static int FindPeak(int[,] matrix, int rows, int columns, int mid)
        {
            int[] max_function = Max(matrix, rows, mid);
            int max_index = max_function[0];
            int max = max_function[1];

            // If we are on the first or last column, 
            // max is a peak 
            if (mid == 0 || mid == columns - 1)
                return max;

            // If mid column maximum is also peak 
            if (max >= matrix[max_index, mid - 1] &&
                max >= matrix[max_index, mid + 1])
                return max;

            // If max is less than its left 
            if (max < matrix[max_index, mid - 1])
                return FindPeak(matrix, rows, columns,
                       (int)(mid - Math.Ceiling((double)(columns - 1 - mid) / 2)));

            // If max is less than its right 
            // if (max < arr[max_index][mid+1]) 
            return FindPeak(matrix, rows, columns,
                   (int)(mid + Math.Ceiling((double)(columns - 1 - mid) / 2)));
        }

        // Function to find the maximum in column 'mid' and its index, 'rows' is number of rows.
        public static int[] Max(int[,] matrix, int rows, int mid)
        {
            int max_index = 0;
            int max = 0;
            for (int i = 0; i < rows; i++)
            {
                if (max < matrix[i, mid])
                {
                    max = matrix[i, mid];
                    max_index = i;
                }
            }
            return new int[] { max_index, max } ;
        }

    }
}
