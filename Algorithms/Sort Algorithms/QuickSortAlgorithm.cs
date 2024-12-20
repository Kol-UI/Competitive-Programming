using System;
namespace CompetitiveProgramming.Algorithms
{
	public class QuickSortAlgorithm
    {
        public static void QuickSort(int[] array)
        {
            QuickSortDescending(array, 0, array.Length - 1);
        }

        private static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right); // Partition the array
                QuickSort(array, left, pivotIndex - 1); // Sort the left sub-array of the pivot
                QuickSort(array, pivotIndex + 1, right); // Sort the right sub-array of the pivot
            }
        }

        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right]; // Choosing the pivot (in this example, the last element of the array)
            int i = left - 1; // Index of the last element smaller than the pivot

            for (int j = left; j < right; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j); // Swap elements to place them in the correct partition
                }
            }

            Swap(array, i + 1, right); // Placing the pivot in its final position
            return i + 1; // Returning the index of the pivot
        }

        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }


        // Descending
        public static void QuickSortDescending(int[] array)
        {
            QuickSortDescending(array, 0, array.Length - 1);
        }

        private static void QuickSortDescending(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = PartitionDescending(array, left, right); // Partition the array in descending order
                QuickSortDescending(array, left, pivotIndex - 1); // Sort the left sub-array of the pivot
                QuickSortDescending(array, pivotIndex + 1, right); // Sort the right sub-array of the pivot
            }
        }

        private static int PartitionDescending(int[] array, int left, int right)
        {
            int pivot = array[right]; // Choosing the pivot (in this example, the last element of the array)
            int i = left - 1; // Index of the last element greater than the pivot

            for (int j = left; j < right; j++)
            {
                if (array[j] >= pivot) // Inverting the condition for descending order
                {
                    i++;
                    Swap(array, i, j); // Swap elements to place them in the correct partition
                }
            }

            Swap(array, i + 1, right); // Placing the pivot in its final position
            return i + 1; // Returning the index of the pivot
        }
    }

}

