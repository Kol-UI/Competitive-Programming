using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.Helpers.Outputs
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
    }
}