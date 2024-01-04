// Count possible ways to construct buildings

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.GeeksForGeeks.Medium.Countpossiblewaystoconstructbuildings
{
    public class Solution
    {
        public static int TotalWays(int N)
        {
            if (N == 1)
                return 4;

            int MOD = 1000000007;

            int countEnd = 1, countEndSpace = 1, prevCountEndSpace;

            for (int i = 2; i <= N; i++)
            {
                prevCountEndSpace = countEndSpace;
                countEndSpace = (countEnd + countEndSpace) % MOD;
                countEnd = prevCountEndSpace;
            }

            long totalWays = (long)(countEndSpace + countEnd) * (countEndSpace + countEnd);
            return (int)(totalWays % MOD);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.TotalWays(1), 4),
                ResultTester.CheckResult<int>(Solution.TotalWays(3), 25),
            };
            return results;
        }
    }
}
