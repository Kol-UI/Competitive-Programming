using System;
namespace CompetitiveProgramming.Algorithms
{
	public class BubbleSortAlgorithm
	{
        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j + 1] < array[j])
                    {
                        int tempo = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = tempo;
                    }
                }
            }
        }

        // Descending
        public static void BubbleSortDescending(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j + 1] > array[j]) // Reverse the condition for descending order
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}

