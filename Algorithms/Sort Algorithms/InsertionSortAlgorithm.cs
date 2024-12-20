using System;
namespace CompetitiveProgramming.Algorithms
{
	public class InsertionSortAlgorithm
	{
        public static void InsertionSort(int[] array)
        {
            int n = array.Length;

            for (int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;

                // Moving elements larger than the key to the right
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                // Inserting the key at its correct position
                array[j + 1] = key;
            }
        }

        // Descending
        public static void InsertionSortDescending(int[] array)
        {
            int n = array.Length;

            for (int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;

                // Moving elements smaller than the key to the right
                while (j >= 0 && array[j] < key) // Reverse the condition for descending order
                {
                    array[j + 1] = array[j];
                    j--;
                }

                // Insert the key at its correct position
                array[j + 1] = key;
            }
        }
    }
}

