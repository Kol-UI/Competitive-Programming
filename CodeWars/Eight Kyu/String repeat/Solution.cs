using System;
using System.Text;

namespace CompetitiveProgramming.CodeWars.EightKyu.Stringrepeat
{
	public class Solution
	{
        // Write a function that accepts an integer n and a string s as parameters, and returns a string of s repeated exactly n times.
        // Examples (input -> output)
        // 6, "I"     -> "IIIIII"
        // 5, "Hello" -> "HelloHelloHelloHelloHello"

        public static string RepeatStr(int n, string s)
        {
            string result = "";
            if (n != 0)
            {
                for (int i = 0; i < n; i++)
                {
                    result += s;
                }
            }
            return result;
        }

        // Concat
        public static string ConcatRepeatStr(int n, string s)
        {
            return String.Concat(Enumerable.Repeat(s, n));
        }

        // Clever
        // StringBuilder
        // Other Ways than StringBuilder : for every loop step a new string must be stored
        public static string StringBuilderRepeatStr(int n, string s)
        {
            return new StringBuilder(s.Length * n).Insert(0, s, n).ToString();
        }
    }
}