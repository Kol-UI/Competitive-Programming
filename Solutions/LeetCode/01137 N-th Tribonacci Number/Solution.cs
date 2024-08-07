using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NthTribonacciNumber
{
    public class Solution
    {
        // The Tribonacci sequence Tn is defined as follows: 
        // T0 = 0, T1 = 1, T2 = 1, and Tn+3 = Tn + Tn+1 + Tn+2 for n >= 0.
        // Given n, return the value of Tn.

        // Example 1:

        // Input: n = 4
        // Output: 4
        // Explanation:
        // T_3 = 0 + 1 + 1 = 2
        // T_4 = 1 + 1 + 2 = 4
        
        // Example 2:

        // Input: n = 25
        // Output: 1389537

        public static int TribonacciMath(int n)
        {
            var a = new int[Math.Max(n + 1, 3)];
            (a[0], a[1], a[2]) = (0, 1, 1);
            for (var i = 3; i <= n; i++)
            {
                a[i] = a[i-1] + a[i-2] + a[i-3];
            }
            return a[n];
        }

        public static int TribonacciFor(int n)
        {
            int[] result = new int[] {0, 1, 1};
            
            if(n < 3)
            {
                return result[n];
            }

            for(int i = 2; i < n; i ++)
            {
                int sum = result.Sum();
                result = new int [] {result[1], result[2], sum};
            }

            return result[2];
        }

        public static int Tribonacci(int n)
        {
            if(n == 0) return 0;
            if(n == 1 || n == 2) return 1;
            int[] dp = new int[n+1];
            dp[0] = 0;
            dp[1] = 1;
            dp[2] = 1;
            if(n < 3)
            {
                return dp[n];
            }
            for(int i = 3; i <= n; i++)
            {
                dp[i] = dp[i-1] + dp[i-2] + dp[i-3];
            }
            return dp[n];
        }

    }

    public class Test
    {
        public static bool[] TestNthTribonacciNumber()
        {
            int n1 = 4;
            int expected1 = 4;
            int n2 = 25;
            int expected2 = 1389537;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.Tribonacci(n1), expected1),
                ResultTester.CheckResult<int>(Solution.Tribonacci(n2), expected2),
                ResultTester.CheckResult<int>(Solution.TribonacciFor(n1), expected1),
                ResultTester.CheckResult<int>(Solution.TribonacciFor(n2), expected2),
                ResultTester.CheckResult<int>(Solution.TribonacciMath(n1), expected1),
                ResultTester.CheckResult<int>(Solution.TribonacciMath(n2), expected2),
            };

            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("N-th Tribonacci Number");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestNthTribonacciNumber());
        }
    }
}