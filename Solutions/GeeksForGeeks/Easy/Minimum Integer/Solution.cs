using System;
using CompetitiveProgramming.TestDrivenDevelopment;

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

    public class Test
    {
        public static bool[] TestMinimumInteger()
        {
            // Case 1
            int N = 3;
            int[] A = { 1, 3, 2 };
            int resultCase1 = GeeksForGeeks.Easy.MinimumInteger.Solution.MinimumInteger(N, A);
            
            // Case 2
            int N2 = 1;
            int[] A2 = { 3 };
            int resultCase2 = GeeksForGeeks.Easy.MinimumInteger.Solution.MinimumInteger(N2, A2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(resultCase1, 2),
                ResultTester.CheckResult<int>(resultCase2, 3)
            };
            return results;
        }
    }
}