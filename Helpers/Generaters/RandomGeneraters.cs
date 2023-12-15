using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.Helpers.Generaters
{
    public class RandomGeneraters
    {
        public static int[] GenerateRandomNumber(int maxNum, int size)
		{
			var array = new int[size];
			var rand = new Random();

			for (int i = 0; i < size; i++)
				array[i] = rand.Next(maxNum + 1);

			return array;
		}

        public static int[] GenerateRandomNegativeNumber(int size)
		{
			var array = new int[size];
			var rand = new Random();

			for (int i = 0; i < size; i++)
				array[i] = rand.Next(-10, 0);

			return array;
		}

        public static int[] GenerateRandomNegativePositiveNumber(int size)
		{
			var array = new int[size];
			var rand = new Random();

			for (int i = 0; i < size; i++)
				array[i] = rand.Next(-10, 10);

			return array;
		}

        public static void ShuffleArray(int[] arr)
        {
            Random rand = new Random();
            for (int i = arr.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
                int tmp = arr[j];
                arr[j] = arr[i];
                arr[i] = tmp;
            }
        }
    }
}