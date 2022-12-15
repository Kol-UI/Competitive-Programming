using System;
namespace CompetitiveProgramming.CodeWars.EightKyu.ReturnNegative
{
	public class Solution
	{
        // In this simple assignment you are given a number and have to make it negative.
        // But maybe the number is already negative?

        // Examples:
        //Kata.MakeNegative(1);  // return -1
        //Kata.MakeNegative(-5); // return -5
        //Kata.MakeNegative(0);  // return 0

        public static int MakeNegative(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else
            {
                bool positive = number > 0;
                if (positive)
                {
                    return number - (number * 2);
                }
                else
                {
                    return number;
                }
            }
        }

        // Using Math
        public static int MakeNegativeMath(int number)
        {
            return -Math.Abs(number);
        }

        // One Line
        public static int MakeNegativeOneLine(int number)
        {
            return number > 0 ? -number : number;
        }
    }
}

