using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
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
            // Tests
            CSharpTDD.StartAllTDD();

            // ResultTester Stats
            ResultTester.GetAllStats();

            // StopWatch
            sw.Stop();
            string stopWatchResult = "Time Elapsed : [" + sw.ElapsedMilliseconds.ToString() + "] ms";
            HightLight(stopWatchResult, ConsoleColor.Red);
            Space();
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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--- {0} ---", StringTitle);
            Console.ResetColor();
        }

        public static void SubTitle(string StringTitle)
        {
            Space();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("- {0} -", StringTitle);
            Console.ResetColor();
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

        public static void Print2DIntArray(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        
        public static void HightLight(string message, ConsoleColor color)
        {
            // "Highlight a specific [value] in a sentence"
            var pieces = Regex.Split(message, @"(\[[^\]]*\])");

            for(int i = 0; i < pieces.Length; i++)
            {
                string piece = pieces[i];
                
                if (piece.StartsWith("[") && piece.EndsWith("]"))
                {
                    Console.ForegroundColor = color;
                    piece = piece.Substring(1, piece.Length - 2);          
                }
                
                Console.Write(piece);
                Console.ResetColor();
            }
            
            Console.WriteLine();
        }

        public static void PrintTestResult(string result, string expected)
        {
            Console.WriteLine("Expected : " + expected);
            Console.WriteLine("Result : " + result);
        }

        // Generate Randoms
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

        public static string ArrayToString<T>(T array)
        {
            if (array == null)
            {
                return string.Empty;
            }
            if (array is Array)
            {
                // Convert array to string
                StringBuilder sb = new StringBuilder();
                foreach (var item in (array as Array)!)
                {
                    sb.Append(ArrayToString(item));
                    sb.Append(", ");
                }
                if (sb.Length > 0)
                {
                    sb.Length -= 2;
                }
                sb.Insert(0, "{ ");
                sb.Append(" }");
                return sb.ToString();
            }
            else
            {
                // Convert non-array type to string
                return array.ToString()!;
            }
        }

        public static string JaggedArrayToString(Array? array)
        {
            if (array == null)
            {
                return string.Empty;
            }
            StringBuilder sb = new StringBuilder();
            void ProcessArray(Array array)
            {
                foreach (var item in array)
                {
                    if (item is Array innerArray)
                    {
                        ProcessArray(innerArray);
                    }
                    else
                    {
                        sb.Append(item).Append(", ");
                    }
                }
            }
            ProcessArray(array);
            return sb.ToString().TrimEnd(' ', ',');
        }
    }
}


/*
            int[] output1 = {0,-1,-1,1};
            int[] output2 = {0,-1,-1,-1,-1};
            int[] output3 = {-1,-1,0,-1};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(result2612_1, output1),
                ResultTester.CheckResult<int[]>(result2612_2, output2),
                ResultTester.CheckResult<int[]>(result2612_3, output3)
            };
            ResultTester.CheckSolution(source, results);
            */


// TODO : Print expected & result for other types
// TODO : 2316 Tests