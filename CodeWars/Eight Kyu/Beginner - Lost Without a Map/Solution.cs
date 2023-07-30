// Beginner - Lost Without a Map

/*
Given an array of integers, return a new array with each value doubled.

For example:

[1, 2, 3] --> [2, 4, 6]

*/

using System;
namespace CompetitiveProgramming.CodeWars.EightKyu.BeginnerLostWithoutaMap
{
    public class Solution
    {
        public static int[] Maps(int[] x)
        {
            int[] doubledArray = new int[x.Length];

                for (int i = 0; i < x.Length; i++)
                {
                    doubledArray[i] = x[i] * 2;
                }

                return doubledArray;
        }

        public static int[] MapsConvertAll(int[] x)
        {
            return Array.ConvertAll(x, n => n * 2);
        } 
    }
}