using System;
namespace CompetitiveProgramming.Algorithms
{
	public class SelectionSortAlgorithm
    {
        public static int[] SelectionSort(int[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length - 1; i++)
            {
                // Find the index of the minimum element in the unsorted portion
                int minIndex = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                // Swap the minimum element with the current element
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
            return arr;
        }

        // Descending
        public static int[] SelectionSortDescending(int[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length - 1; i++)
            {
                // Find the index of the maximum element in the unsorted portion
                int maxIndex = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] > arr[maxIndex])
                    {
                        maxIndex = j;
                    }
                }

                // Swap the maximum element with the current element
                int temp = arr[i];
                arr[i] = arr[maxIndex];
                arr[maxIndex] = temp;
            }
            return arr;
        }
    }
}

