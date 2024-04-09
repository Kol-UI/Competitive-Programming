// Time Needed to Buy Tickets


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.TimeNeededtoBuyTickets
{
    public class Solution
    {
        public static int TimeRequiredToBuy(int[] tickets, int k) => tickets
                .Select((n, i) => Math.Min(n, tickets[k]) - (i > k && n >= tickets[k] ? 1 : 0))
                .Sum();
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.TimeRequiredToBuy(new int[]{2,3,2}, 2), 6),
                ResultTester.CheckResult<int>(Solution.TimeRequiredToBuy(new int[]{5,1,1,1}, 0), 8),
            };
            return results;
        }
    }
}