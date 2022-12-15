using System;
namespace CompetitiveProgramming.CodeWars.SevenKyu.Isograms
{
	public class Solution
	{
        // It is an Isogram ?
        public static bool IsIsogram(string str)
        {
            int strLen = str.Length;
            return str.ToLower().Distinct().Count() == strLen;
        }
    }
}

