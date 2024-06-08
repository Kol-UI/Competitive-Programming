using System;
namespace CompetitiveProgramming.Helpers
{
	public class BinarySearchAlgorithm
	{
        public static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                    return mid; // The target value has been found at index 'mid'

                if (array[mid] < target)
                    left = mid + 1; // "The target value is larger, we search in the right half
                else
                    right = mid - 1; // The target value is smaller, we search in the left half
            }

            return -1; // Element not found
        }

        // Descending
        public static int BinarySearchDescending(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                    return mid;

                if (array[mid] < target)
                    right = mid - 1; // Changes !
                else
                    left = mid + 1; // Changes !
            }

            return -1; // Element not found
        }
    }
}

