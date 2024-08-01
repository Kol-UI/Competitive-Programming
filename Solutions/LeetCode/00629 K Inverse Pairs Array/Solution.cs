// K Inverse Pairs Array


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.KInversePairsArray
{
    public class Solution
    {
        private const int Mod = 1000000007;
        
        public static int KInversePairs(int n, int k)
        {
            var memoization = new int[n + 1, k + 1];

            for (var i = 1; i <= n; i++)
            {
                memoization[i, 0] = 1;

                for (var j = 1; j <= k; j++)
                {
                    for (var p = 0; p <= Math.Min(j, i - 1); p++)
                    {
                        memoization[i, j] = (memoization[i, j] + memoization[i - 1, j - p]) % Mod;
                    }
                }
            }

            return memoization[n, k];
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.KInversePairs(3, 0), 1),
                ResultTester.CheckResult<int>(Solution.KInversePairs(3, 1), 2),
            };
            return results;
        }
    }
    
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("K Inverse Pairs Array");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}