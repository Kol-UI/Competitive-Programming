using System;
namespace CompetitiveProgramming.CodeWars.EightKyu.RemoveExclamationMarks
{
	public class Solution
	{
        // Remove all exclamation marks of a string
        public static string RemoveExclamationMarks(string s)
        {
            return string.IsNullOrEmpty(s) ? s : s.Replace("!", "");
        }
    }
}

