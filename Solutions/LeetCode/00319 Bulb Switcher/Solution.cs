// Bulb Switcher
/*
There are n bulbs that are initially off. You first turn on all the bulbs, then you turn off every second bulb.

On the third round, you toggle every third bulb (turning on if it's off or turning off if it's on). For the ith round, you toggle every i bulb. For the nth round, you only toggle the last bulb.

Return the number of bulbs that are on after n rounds.

 

Example 1:
Input: n = 3
Output: 1
Explanation: At first, the three bulbs are [off, off, off].
After the first round, the three bulbs are [on, on, on].
After the second round, the three bulbs are [on, off, on].
After the third round, the three bulbs are [on, off, off]. 
So you should return 1 because there is only one bulb is on.

Example 2:

Input: n = 0
Output: 0

Example 3:

Input: n = 1
Output: 1
 

Constraints:

0 <= n <= 109
*/
using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BulbSwitcher
{
    public class Solution
    {
        public static int BulbSwitch(int n)
        {
            return (int)Math.Sqrt(n);
        }
    }

    public class Test
    {
        public static bool[] TestBulbSwitcher()
        {
            // Case 1
            int Case1_319 = Solution.BulbSwitch(3);

            // Case 2
            int Case2_319 = Solution.BulbSwitch(0);

            // Case 3
            int Case3_319 = Solution.BulbSwitch(1);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_319, 1),
                ResultTester.CheckResult<int>(Case2_319, 0),
                ResultTester.CheckResult<int>(Case3_319, 1)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Bulb Switcher");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestBulbSwitcher());
        }
    }
}