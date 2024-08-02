// Min Cost Climbing Stairs

/*
You are given an integer array cost where cost[i] is the cost of ith step on a staircase. Once you pay the cost, you can either climb one or two steps.

You can either start from the step with index 0, or the step with index 1.

Return the minimum cost to reach the top of the floor.

 

Example 1:

Input: cost = [10,15,20]
Output: 15
Explanation: You will start at index 1.
- Pay 15 and climb two steps to reach the top.
The total cost is 15.

Example 2:

Input: cost = [1,100,1,1,1,100,1,1,100,1]
Output: 6
Explanation: You will start at index 0.
- Pay 1 and climb two steps to reach index 2.
- Pay 1 and climb two steps to reach index 4.
- Pay 1 and climb two steps to reach index 6.
- Pay 1 and climb one step to reach index 7.
- Pay 1 and climb two steps to reach index 9.
- Pay 1 and climb one step to reach the top.
The total cost is 6.
*/


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinCostClimbingStairs
{
    public class Solution
    {
        public static int MinCostClimbingStairs(int[] cost)
        {
            int a = cost[cost.Length - 1];
            int b = cost[cost.Length - 2];
            int c = 0;
            
            for(int i = cost.Length - 3; i >= 0; i--)
            {
                c = cost[i] + Math.Min(b, a);
                a = b;
                b = c;
            }
            
            return Math.Min(b, a);
        }
    }

    public class Test
    {
        public static bool[] TestMinCostClimbingStairs()
        {
            // Case 1
            int[] cost1 = {10,15,20};
            int result1 = Solution.MinCostClimbingStairs(cost1);

            // Case 2
            int[] cost2 = {1,100,1,1,1,100,1,1,100,1};
            int result2 = Solution.MinCostClimbingStairs(cost2);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 15),
                ResultTester.CheckResult<int>(result2, 6)
            };

            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Min Cost Climbing Stairs");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestMinCostClimbingStairs());
        }
    }
}