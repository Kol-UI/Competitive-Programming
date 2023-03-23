using System;
using System.Linq;
namespace CompetitiveProgramming.CodeWars.EightKyu.ConvertaStringtoaNumber
{
    /*
        We need a function that can transform a string into a number. What ways of achieving this do you know?
        Note: Don't worry, all inputs will be strings, and every string is a perfectly valid representation of an integral number.

        Examples
        "1234" --> 1234
        "605"  --> 605
        "1405" --> 1405
        "-7" --> -7
    */
	public class Solution
	{
        // Error if null
        public static int StringToNumber(String str)
        {
            int result = 0;
            return result = Convert.ToInt32(str);
        }

        // No error if null (return 0)
        public static int StringToNumberClever(String str)
        {
            return (int.Parse(str));
        }
    }
}