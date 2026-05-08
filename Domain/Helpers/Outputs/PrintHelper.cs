using System.Text.RegularExpressions;

namespace CompetitiveProgramming.Helpers
{
    public class PrintHelper
    {
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

        public static void PrintList<T>(List<T> list)
        {
            Console.Write("[");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
                if (i < list.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
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

        public static void PrintCodeForcesRanksStats(Dictionary<ProblemCategory, int> counterDifficulty)
        {
            var targets = new[]
            {
                ProblemCategory.CF800, ProblemCategory.CF900, ProblemCategory.CF1000,
                ProblemCategory.CF1100, ProblemCategory.CF1200, ProblemCategory.CF1300,
                ProblemCategory.CF1400, ProblemCategory.CF1500
            };

            Console.WriteLine("| Ranks | Numbers |");
            Console.WriteLine("| :--- | :---: |");

            foreach (var cat in targets)
            {
                string label = cat.ToString().Replace("CF", "");
                int count = counterDifficulty.GetValueOrDefault(cat);
                Console.WriteLine($"| {label} | {count} |");
            }
            StyleHelper.Space();
        }

        public static void PrintCodeWarsKyusStats(Dictionary<ProblemCategory, int> counterDifficulty)
        {
            var targets = new[]
            {
                ProblemCategory.EightKyu, ProblemCategory.SevenKyu, ProblemCategory.SixKyu,
                ProblemCategory.FiveKyu, ProblemCategory.FourKyu, ProblemCategory.ThreeKyu,
                ProblemCategory.TwoKyu, ProblemCategory.OneKyu
            };

            Console.WriteLine("| Kyus | Numbers |");
            Console.WriteLine("| :--- | :---: |");

            foreach (var cat in targets)
            {
                string label = cat.ToString().Replace("Kyu", "");
                int count = counterDifficulty.GetValueOrDefault(cat);
                Console.WriteLine($"| {label} | {count} |");
            }
            StyleHelper.Space();
        }
    }
}