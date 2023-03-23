using System;
namespace CompetitiveProgramming.GeeksForGeeks.School.SecondLargest
{
	public class Solution
	{
        public static int PrintSecondLargest(int[] arr, int n)
        {
            Array.Sort(arr);
            int result = 0;
            for (int i = n - 2; i >= 0; i--)
            {
                if (arr[i] != arr[n - 1])
                {
                    result = arr[i];
                    break;
                }
            }
            
            if (result == 0)
            {
                return -1;
            }

            return result;
        }
    }
}