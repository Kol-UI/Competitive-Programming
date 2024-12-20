using System;
namespace CompetitiveProgramming.Algorithms
{
	public class LinearSearchAlgorithm
	{
        public static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i; // Return index at first occurrence
                }
            }

            return -1; // Value not found
        }

        // Multiple
        public static List<int> LinearSearchMultiple(int[] arr, int target)
        {
            List<int> indices = new();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    indices.Add(i);
                }
            }

            return indices;
        }

        // Descending
        public static int LinearSearchDescending(int[] arr, int target)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == target)
                {
                    return i; // Return index at first occurrence
                }
            }

            return -1; // Value not found
        }

        // Multiple & Descending
        public static List<int> LinearSearchMultipleDescending(int[] arr, int target)
        {
            List<int> indices = new();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == target)
                {
                    indices.Add(i);
                }
            }

            indices.Reverse(); // Inverse the list to maintain the descending order of indices

            return indices;
        }
    }
}

