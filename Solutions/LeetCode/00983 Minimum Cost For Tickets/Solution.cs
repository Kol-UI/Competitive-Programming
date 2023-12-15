using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumCostForTickets
{


/*
You have planned some train traveling one year in advance. The days of the year in which you will travel are given as an integer array days. Each day is an integer from 1 to 365.

Train tickets are sold in three different ways:

a 1-day pass is sold for costs[0] dollars,
a 7-day pass is sold for costs[1] dollars, and
a 30-day pass is sold for costs[2] dollars.
The passes allow that many days of consecutive travel.

For example, if we get a 7-day pass on day 2, then we can travel for 7 days: 2, 3, 4, 5, 6, 7, and 8.
Return the minimum number of dollars you need to travel every day in the given list of days.


Example 1:

Input: days = [1,4,6,7,8,20], costs = [2,7,15]
Output: 11
Explanation: For example, here is one way to buy passes that lets you travel your travel plan:
On day 1, you bought a 1-day pass for costs[0] = $2, which covered day 1.
On day 3, you bought a 7-day pass for costs[1] = $7, which covered days 3, 4, ..., 9.
On day 20, you bought a 1-day pass for costs[0] = $2, which covered day 20.
In total, you spent $11 and covered all the days of your travel.


Example 2:

Input: days = [1,2,3,4,5,6,7,8,9,10,30,31], costs = [2,7,15]
Output: 17
Explanation: For example, here is one way to buy passes that lets you travel your travel plan:
On day 1, you bought a 30-day pass for costs[2] = $15 which covered days 1, 2, ..., 30.
On day 31, you bought a 1-day pass for costs[0] = $2 which covered day 31.
In total, you spent $17 and covered all the days of your travel.
*/

    public class Solution
    {
        public static int MincostTickets(int[] days, int[] costs)
        {
            int[] dp = new int[days.Length];
            Array.Fill(dp, int.MaxValue);

            return GetMinCost(days, costs, dp, 0);
        }

        private static int GetMinCost(int[] days, int[] costs, int[] dp, int currentDayIdx){
            if(currentDayIdx >= days.Length){
                return 0;
            }

            if(dp[currentDayIdx] != int.MaxValue){
                return dp[currentDayIdx];
            }

            dp[currentDayIdx] = costs[0] + GetMinCost(days, costs, dp, currentDayIdx+1);

            int seventhDay = days[currentDayIdx] + 7;
            int thirtyDay = days[currentDayIdx] + 30;
            int movingDayIndex = currentDayIdx;

            while(movingDayIndex < days.Length && days[movingDayIndex] < seventhDay){
                movingDayIndex++;
            }

            dp[currentDayIdx] = Math.Min(costs[1] + GetMinCost(days, costs, dp, movingDayIndex), dp[currentDayIdx]);

            while(movingDayIndex < days.Length && days[movingDayIndex] < thirtyDay){
                movingDayIndex++;
            }

            dp[currentDayIdx] = Math.Min(costs[2] + GetMinCost(days, costs, dp, movingDayIndex), dp[currentDayIdx]);

            return dp[currentDayIdx];
        }
    }

    public class Test
    {
        public static bool[] TestMinimumCostForTickets()
        {
            // Case 1
            int[] days983Case1 = { 1, 4, 6, 7, 8, 20 };
            int[] costs983Case1 = { 2, 7, 15 };
            int result983Case1 = Solution.MincostTickets(days983Case1, costs983Case1);

            // Case 2
            int[] days983Case2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 30, 31 };
            int[] costs983Case2 = { 2, 7, 15 };
            int result983Case2 = Solution.MincostTickets(days983Case2, costs983Case2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result983Case1, 11),
                ResultTester.CheckResult<int>(result983Case2, 17)
            };

            return results;
        }
    }

}