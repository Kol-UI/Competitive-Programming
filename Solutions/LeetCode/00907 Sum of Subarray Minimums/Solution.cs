// Sum of Subarray Minimums


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.SumofSubarrayMinimums
{
    public class Solution
    {
        public static int SumSubarrayMins(int[] arr)
        {
            const int MOD = 1000000007;
            int n = arr.Length;
            long result = 0;

            Stack<int> stack = new();

            for (int i = 0; i <= n; i++)
            {
                while (stack.Count > 0 && (i == n || arr[i] < arr[stack.Peek()]))
                {
                    int j = stack.Pop();
                    int left = stack.Count > 0 ? stack.Peek() : -1;
                    result = (result + (long) arr[j] * (i - j) * (j - left)) % MOD;
                }
                if (i < n)
                {
                    stack.Push(i);
                }
            }

            return (int) result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.SumSubarrayMins(new int[]{3,1,2,4}), 17),
                ResultTester.CheckResult<int>(Solution.SumSubarrayMins(new int[]{11,81,94,43,3}), 444),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("907");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}