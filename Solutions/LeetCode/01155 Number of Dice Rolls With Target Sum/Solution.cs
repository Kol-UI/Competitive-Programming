// Number of Dice Rolls With Target Sum



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.NumberofDiceRollsWithTargetSum
{
    public class Solution
    {
        public static int NumRollsToTarget(int n, int k, int target)
        {
            long[,] memo = new long[n+1, target+1];

            for(int i = 0; i < memo.GetLength(0); i++)
            {
                for(int j = 0; j < memo.GetLength(1); j++)
                {
                    memo[i, j] = -1;
                }
            }

            return (int)NumRollsToTargetRec(0, n, k, target, memo);
        }

        public static long NumRollsToTargetRec(int t, int n, int k, int target, long[,] memo)
        {
            long value = 1000000007;

            if(target < 0 || t > n)
            {
                return 0;
            }

            if(t == n && target == 0)
            {
                return 1;
            }

            if(memo[t, target] != -1)
            {
                return memo[t,target];
            }

            long result = 0;

            for(int i = 1; i <= k; i++)
            {
                result += (NumRollsToTargetRec(t + 1, n, k, target-i, memo) % value);
            }
            
            return memo[t, target] = result % value;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.NumRollsToTarget(1, 6, 3), 1),
                ResultTester.CheckResult<int>(Solution.NumRollsToTarget(2, 6, 7), 6),
                ResultTester.CheckResult<int>(Solution.NumRollsToTarget(30, 30, 500), 222616187),
            };
            return results;
        }
    }
}