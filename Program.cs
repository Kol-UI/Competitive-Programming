using System;
using System.Collections.Generic;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming
{
    // dotnet run
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            Console.WriteLine("Hello World!");
            CSharpTDD.StartAllTDD();

            sw.Stop();
            Console.WriteLine("\nTime Elapsed: {0} ms", sw.ElapsedMilliseconds);
        }

        // Helpers

        // Console Style Helpers
        public static void Space()
        {
            Console.WriteLine();
        }

        public static void Title(string StringTitle)
        {
            Space();
            Console.WriteLine("--- {0} ---", StringTitle);
        }

        public static void SubTitle(string StringTitle)
        {
            Space();
            Console.WriteLine("- {0} -", StringTitle);
        }

        // Console Print Helpers
        public static void PrintArray(int[] array)
        {
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        public static void PrintStringArray(string[] array)
        {
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        public static void PrintCharArray(char[] array)
        {
            Console.WriteLine("Result : {0}",new string(array));
        }

        public static void PrintBoolArray(bool[] array)
        {
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        public static void PrintBeforeAfterIntArray(int[] before, int[] after)
        {
            string beforeValue = string.Join(", ", before);
            string afterValue = string.Join(", ", after);
            Console.WriteLine("Before : [{0}] - After : [{1}]", beforeValue, afterValue);
        }

        public static void PrintBeforeAfterStringToString(string before, string after)
        {
            Console.WriteLine("Before : '{0}' - After : '{1}'", before, after);
        }

        public static void PrintBeforeAfterIntToInt(int before, int after)
        {
            Console.WriteLine("Before : '{0}' - After : '{1}'", before, after);
        }

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

        // Other Helpers
        public static bool isVowel(char c)
        {
            return (c == 'a') || (c == 'e') || (c == 'i') || (c == 'o') || (c == 'u');
        }
    }
}