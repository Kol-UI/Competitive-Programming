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
			// int[size] : 0 <= value <= maxNum
			var array = new int[size];
			var rand = new Random();

			for (int i = 0; i < size; i++)
				array[i] = rand.Next(maxNum + 1);

			return array;
		}

        public static int[] GenerateRandomNegativeNumber(int size)
		{
			// int[size] : -10 <= value < 0
			var array = new int[size];
			var rand = new Random();

			for (int i = 0; i < size; i++)
				array[i] = rand.Next(-10, 0);

			return array;
		}

        public static int[] GenerateRandomNegativePositiveNumber(int size)
		{
			// int[size] : -10 <= value < 10
			var array = new int[size];
			var rand = new Random();

			for (int i = 0; i < size; i++)
				array[i] = rand.Next(-10, 10);

			return array;
		}

		public static string GenerateRandomPositiveNumberAsString()
		{
			// 1 <= value <= 1 000 000 000
			Random random = new();
			int randomNumber = random.Next(1, 1000000001);

			return randomNumber.ToString();
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