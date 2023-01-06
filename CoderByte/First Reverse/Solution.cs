using System;
namespace CompetitiveProgramming.CoderByte.FirstReverse
{
    public class Solution
    {
        //Have the function FirstReverse(str) take the str parameter being passed and return the string in reversed order.
        //For example: if the input string is "Hello World and Coders",
        //Then your program should return the string sredoC dna dlroW olleH.

        public static string FirstReverseFunc(string str)
        {
            char[] toReverseArray = str.ToCharArray();
            Array.Reverse(toReverseArray);

            return new string(toReverseArray);

        }
    }
}

