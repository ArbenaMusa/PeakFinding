namespace PeakFinding
{
    public static class PeakFinder
    {
        public static int FindPeak(int[,] matrix, int left = 0, int right = -1)
        {
            if (right == -1) right = matrix.GetLength(1); // right = number of columns

            int j = (left + right) / 2; // mid column
            int[] maxArray = FindMax(matrix, j); //returns an array of (index of max element, max element)
            int max_index = maxArray[0]; // index of largest element in mid column
            int max_element = maxArray[1]; // largest element in mid column

            // If we are on the first or last column, max_element is a peak
            if (j == 0 || j == matrix.GetLength(1))
                return max_element;

            // if max element is bigger than his neighbours, max_element is a peak
            else if (max_element >= matrix[max_index, j - 1] && max_element >= matrix[max_index, j + 1])
                return max_element;

            // If max element is less than its left, pick left columns
            else if (matrix[max_index, j - 1] > matrix[max_index, j])
            {
                right = j;
                return FindPeak(matrix, left, right);
            }
            // If max element is less than its right, pick right columns
            else
            {
                left = j;
                return FindPeak(matrix, left, right);
            }
        }

        // Function to find the maximum and its index for a column
        static int[] FindMax(int[,] matrix, int column)
        {
            int max = 0;
            int index = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (max < matrix[i, column])
                {
                    max = matrix[i,column];
                    index = i;
                }
            }
            return new int[] { index, max };
        }

    }
}
