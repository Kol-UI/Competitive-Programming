using System;

namespace CompetitiveProgramming.GeeksForGeeks.Easy.MinimumInteger
{
	public class Solution
	{
        public static int MinimumInteger(int N, int[] A)
        {
            long sum = 0;
            for(int i = 0; i < N; i++)
            {
                sum += A[i];
            }
            long min = int.MaxValue;
            for(int i = 0; i < N; i++)
            {
                if((Math.Log(sum) <= Math.Log(N) + Math.Log(A[i])))
                {
                    min = Math.Min(min, A[i]);
                }
            }
            return (int)min;
        }
    }
}