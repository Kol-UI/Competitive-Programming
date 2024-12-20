using System;
namespace CompetitiveProgramming.Algorithms
{
	public class MergeSortAlgorithm
	{
        public static void MergeSort(int[] arr, int low, int high)
        {
            // low: index of the first element in the unsorted part
            // high: index of the last element in the unsorted part

            if (low < high)
            {
                int middle = (low + high) / 2;
                MergeSort(arr, low, middle); // Sort the first half of the list
                MergeSort(arr, middle + 1, high); // Sort the second half of the list
                Merge(arr, low, middle, high); // Merge the two sorted halves
            }
        }

        private static void Merge(int[] arr, int low, int middle, int high)
        {
            int n1 = middle - low + 1; // Size of the first half
            int n2 = high - middle; // Size of the second half

            // Create temporary arrays to store the subarrays
            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];

            // Copy the elements into the temporary subarrays
            for (int i = 0; i < n1; i++)
                leftArr[i] = arr[low + i];
            for (int j = 0; j < n2; j++)
                rightArr[j] = arr[middle + 1 + j];

            // Merge the subarrays into a single sorted list
            int leftIndex = 0;
            int rightIndex = 0;
            int mergedIndex = low;

            while (leftIndex < n1 && rightIndex < n2)
            {
                if (leftArr[leftIndex] <= rightArr[rightIndex])
                {
                    arr[mergedIndex] = leftArr[leftIndex];
                    leftIndex++;
                }
                else
                {
                    arr[mergedIndex] = rightArr[rightIndex];
                    rightIndex++;
                }
                mergedIndex++;
            }

            // Copy any remaining elements from the left subarray if there are any
            while (leftIndex < n1)
            {
                arr[mergedIndex] = leftArr[leftIndex];
                leftIndex++;
                mergedIndex++;
            }

            // Copy any remaining elements from the right subarray if there are any
            while (rightIndex < n2)
            {
                arr[mergedIndex] = rightArr[rightIndex];
                rightIndex++;
                mergedIndex++;
            }
        }

        // Descending
        public static void MergeSortDescending(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int middle = (low + high) / 2;
                MergeSortDescending(arr, low, middle); // Sort the first half of the list
                MergeSortDescending(arr, middle + 1, high); // Sort the second half of the list
                MergeDescending(arr, low, middle, high); // Merge the two sorted halves in descending order
            }
        }

        private static void MergeDescending(int[] arr, int low, int middle, int high)
        {
            int n1 = middle - low + 1; // Size of the first half
            int n2 = high - middle; // Size of the second half

            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArr[i] = arr[low + i];
            for (int j = 0; j < n2; j++)
                rightArr[j] = arr[middle + 1 + j];

            int leftIndex = 0;
            int rightIndex = 0;
            int mergedIndex = low;

            while (leftIndex < n1 && rightIndex < n2)
            {
                if (leftArr[leftIndex] >= rightArr[rightIndex]) // Invert the condition for descending order
                {
                    arr[mergedIndex] = leftArr[leftIndex];
                    leftIndex++;
                }
                else
                {
                    arr[mergedIndex] = rightArr[rightIndex];
                    rightIndex++;
                }
                mergedIndex++;
            }

            while (leftIndex < n1)
            {
                arr[mergedIndex] = leftArr[leftIndex];
                leftIndex++;
                mergedIndex++;
            }

            while (rightIndex < n2)
            {
                arr[mergedIndex] = rightArr[rightIndex];
                rightIndex++;
                mergedIndex++;
            }
        }
    }
}

