using System;
namespace CompetitiveProgramming.CodeWars.EightKyu.Sumofpositive
{
	public class Solution
	{
        // You get an array of numbers, return the sum of all of the positives ones.
        // Example [1,-4,7,12] => 1 + 7 + 12 = 20
        // Note: if there is nothing to sum, the sum is default to 0.

        public static int PositiveSum(int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    result += arr[i];
                }
            }
            return result;
        }

        // Clever
        public static int CleverPositiveSum(int[] arr)
        {
            return arr.Where(x => x > 0).Sum();
        }
    }
}