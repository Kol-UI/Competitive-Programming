using System;
namespace CompetitiveProgramming.Algorithms
{
	public class ShellSortAlgorithm
	{
        public static void ShellSort(int[] array)
        {
            int n = array.Length;

            for (int interval = n / 2; interval > 0; interval /= 2)
            {
                for (int i = interval; i < n; i++)
                {
                    int temp = array[i];
                    int j = i;

                    while (j >= interval && array[j - interval] > temp)
                    {
                        array[j] = array[j - interval];
                        j -= interval;
                    }

                    array[j] = temp;
                }
            }
        }

        // Descending
        public static void ShellSortDescending(int[] array)
        {
            int n = array.Length;

            for (int interval = n / 2; interval > 0; interval /= 2)
            {
                for (int i = interval; i < n; i++)
                {
                    int temp = array[i];
                    int j = i;

                    while (j >= interval && array[j - interval] < temp) // Invert the condition for descending order
                    {
                        array[j] = array[j - interval];
                        j -= interval;
                    }

                    array[j] = temp;
                }
            }
        }
    }
}

