// We need a function that can transform a number (integer) into a string.
// What ways of achieving this do you know?

// Examples (input --> output):
// 123  --> "123"
// 999  --> "999"
// -100 --> "-100"

using System;
namespace CompetitiveProgramming.CodeWars.EightKyu.ConvertaNumbertoaString
{
	public class Solution
	{
        public static string NumberToString(int num)
        {
            return num.ToString();
        }
    }
}