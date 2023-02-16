using System;
namespace CompetitiveProgramming.CodeWars.EightKyu.ConvertbooleanvaluestostringsYesorNo
{
	public class Solution
	{
        // Complete the method that takes a boolean value and return a "Yes" string for true, or a "No" string for false.
        public static string boolToWord(bool word)
        {
            if (word == true)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }

        // Clever
        public static string boolToWordClever(bool word)
        {
            return word ? "Yes" : "No";
        }
    }
}