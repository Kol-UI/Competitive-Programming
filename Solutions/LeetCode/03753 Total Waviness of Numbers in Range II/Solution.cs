// Total Waviness of Numbers in Range II
namespace CompetitiveProgramming.LeetCode.TotalWavinessofNumbersinRangeII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8618

using System;
using System.Collections.Generic;

public class Solution
{
    private Tuple<long, long>[,,,,] memo;
    private string numStr;

    public long TotalWaviness(long num1, long num2)
    {
        return GetWavinessUpTo(num2) - GetWavinessUpTo(num1 - 1);
    }

    private long GetWavinessUpTo(long n)
    {
        if (n < 100) return 0; 
        
        numStr = n.ToString();
        int len = numStr.Length;
        
        memo = new Tuple<long, long>[len, 11, 11, 2, 2];

        var result = Dp(0, 10, 10, 0, 0);
        return result.Item2;
    }

    private Tuple<long, long> Dp(int index, int prev, int prev2, int isLess, int isStarted)
    {
        if (index == numStr.Length)
        {
            return new Tuple<long, long>(1, 0);
        }

        if (memo[index, prev, prev2, isLess, isStarted] != null)
        {
            return memo[index, prev, prev2, isLess, isStarted];
        }

        long totalCount = 0;
        long totalWaviness = 0;

        int limit = (isLess == 1) ? 9 : (numStr[index] - '0');

        for (int d = 0; d <= limit; d++)
        {
            int nextIsLess = (isLess == 1 || d < limit) ? 1 : 0;
            int nextIsStarted = (isStarted == 1 || d > 0) ? 1 : 0;

            int nextPrev = d;
            int nextPrev2 = prev;

            if (isStarted == 0 && d == 0)
            {
                nextPrev = 10;
                nextPrev2 = 10;
            }

            var nextRes = Dp(index + 1, nextPrev, nextPrev2, nextIsLess, nextIsStarted);
            long count = nextRes.Item1;
            long waviness = nextRes.Item2;

            int wavinessContribution = 0;
            if (isStarted == 1 && prev2 != 10 && prev != 10)
            {
                if (prev > prev2 && prev > d)
                {
                    wavinessContribution = 1;
                }
                else if (prev < prev2 && prev < d)
                {
                    wavinessContribution = 1;
                }
            }

            totalCount = (totalCount + count);
            totalWaviness = (totalWaviness + waviness + (wavinessContribution * count));
        }

        return memo[index, prev, prev2, isLess, isStarted] = new Tuple<long, long>(totalCount, totalWaviness);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long>(solution.TotalWaviness(120, 130), 3),
            ResultTester.CheckResult<long>(solution.TotalWaviness(198, 202), 3),
            ResultTester.CheckResult<long>(solution.TotalWaviness(4848, 4848), 2),
        ];
        return results;
    }
}

#pragma warning restore CS8618
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Total Waviness of Numbers in Range II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}