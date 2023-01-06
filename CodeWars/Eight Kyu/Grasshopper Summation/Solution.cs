using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;

namespace CompetitiveProgramming.CodeWars.EightKyu.GrasshopperSummation
{
    public class Solution
	{
        //Write a program that finds the summation of every number from 1 to num.
        //The number will always be a positive integer greater than 0.

        //For example (Input -> Output):

        //2 -> 3 (1 + 2)
        //8 -> 36 (1 + 2 + 3 + 4 + 5 + 6 + 7 + 8)
        public static int summation(int num)
        {
            return Enumerable.Range(1, num).Sum();
        }
    }
}

