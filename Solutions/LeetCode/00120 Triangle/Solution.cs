// Triangle

/*
Given a triangle array, return the minimum path sum from top to bottom.

For each step, you may move to an adjacent number of the row below. More formally, if you are on index i on the current row, you may move to either index i or index i + 1 on the next row.

 

Example 1:

Input: triangle = [[2],[3,4],[6,5,7],[4,1,8,3]]
Output: 11
Explanation: The triangle looks like:
   2
  3 4
 6 5 7
4 1 8 3
The minimum path sum from top to bottom is 2 + 3 + 5 + 1 = 11 (underlined above).

Example 2:

Input: triangle = [[-10]]
Output: -10
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.Triangle
{
    public class Solution
    {
        public static int MinimumTotal(IList<IList<int>> triangle)
        {
            int m = triangle.Count;
            List<int> dp = new List<int>();
            dp.Add(triangle[0][0]);

            for(int i = 1; i < m; i++)
            {
                int n = triangle[i].Count;
                List<int> tmpDp = new List<int>();
                for(int j = 0; j < n; j++)
                {
                    int result = 0;
                    if(j == 0)
                    {
                        result = triangle[i][j] + dp[0];
                    }
                    else if(j == n-1)
                    {
                        result = triangle[i][j] + dp[j-1];
                    }
                    else
                    {
                        result = triangle[i][j] + Math.Min(dp[j], dp[j-1]);
                    }
                    tmpDp.Add(result);
                }
                dp = tmpDp;
            }

            return dp.Min();
        }
    }

    public class Test
    {
        public static bool[] TestTriangle()
        {
            int[][] case1_120 = new int[][]
            {
                new int[] { 2 },
                new int[] { 3,4 },
                new int[] { 6,5,7 },
                new int[] { 4,1,8,3 }
            };

            int[][] case2_120 = new int[][]
            {
                new int[] { -10 }
            };
            int output1_120 = 11;
            int output2_120 = -10;

            int result1 = Solution.MinimumTotal(case1_120);
            int result2 = Solution.MinimumTotal(case2_120);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, output1_120),
                ResultTester.CheckResult<int>(result2, output2_120)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Tringle");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestTriangle());
        }
    }
}