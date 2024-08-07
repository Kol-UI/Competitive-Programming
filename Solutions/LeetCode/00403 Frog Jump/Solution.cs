// Frog Jump

/*
A frog is crossing a river. The river is divided into some number of units, and at each unit, there may or may not exist a stone. The frog can jump on a stone, but it must not jump into the water.

Given a list of stones' positions (in units) in sorted ascending order, determine if the frog can cross the river by landing on the last stone. Initially, the frog is on the first stone and assumes the first jump must be 1 unit.

If the frog's last jump was k units, its next jump must be either k - 1, k, or k + 1 units. The frog can only jump in the forward direction.

 

Example 1:

Input: stones = [0,1,3,5,6,8,12,17]
Output: true
Explanation: The frog can jump to the last stone by jumping 1 unit to the 2nd stone, then 2 units to the 3rd stone, then 2 units to the 4th stone, then 3 units to the 6th stone, 4 units to the 7th stone, and 5 units to the 8th stone.

Example 2:

Input: stones = [0,1,2,3,4,8,9,11]
Output: false
Explanation: There is no way to jump to the last stone as the gap between the 5th and 6th stone is too large.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FrogJump
{
    public class Solution
    {
        public static bool CanCross(int[] stones)
        {
            Dictionary<int, HashSet<int>> dp = new Dictionary<int, HashSet<int>>();
            for (int i = 0; i < stones.Length; i++)
            {
                dp.Add(stones[i], new HashSet<int>());
            }
            dp[0].Add(0);
            
            for (int i = 0; i < stones.Length; i++)
            {
                foreach (int jump in dp[stones[i]])
                {
                    for (int step = jump - 1; step <= jump + 1; step++)
                    {
                        if (step > 0 && dp.ContainsKey(stones[i] + step))
                        {
                            dp[stones[i] + step].Add(step);
                        }
                    }
                }
            }
            
            return dp[stones[stones.Length - 1]].Count > 0;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int[] stones1 = {0,1,3,5,6,8,12,17};
            int[] stones2 = {0,1,2,3,4,8,9,11};


            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.CanCross(stones1), true),
                ResultTester.CheckResult<bool>(Solution.CanCross(stones2), false),
            };
            return results;
        }
    }
    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Frog Jump");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}