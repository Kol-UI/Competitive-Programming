// Distribute Candies Among Children I

/*
You are given two positive integers n and limit.

Return the total number of ways to distribute n candies among 3 children such that no child gets more than limit candies.

 

Example 1:

Input: n = 5, limit = 2
Output: 3
Explanation: There are 3 ways to distribute 5 candies such that no child gets more than 2 candies: (1, 2, 2), (2, 1, 2) and (2, 2, 1).

Example 2:

Input: n = 3, limit = 3
Output: 10
Explanation: There are 10 ways to distribute 3 candies such that no child gets more than 3 candies: (0, 0, 3), (0, 1, 2), (0, 2, 1), (0, 3, 0), (1, 0, 2), (1, 1, 1), (1, 2, 0), (2, 0, 1), (2, 1, 0) and (3, 0, 0).
*/

using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.DistributeCandiesAmongChildrenI
{
    public class Solution
    {
        public static int DistributeCandies(int n, int limit)
        {
            if(n > 3 * limit)
            {
                return 0;
            }

            long result = (n + 1) * (n + 2) / 2;

            if(n > limit)
            {
                result -= 3 * (n - limit) * (n - limit + 1) / 2;
            }

            if(n - 2 >= 2 * limit)
            {
                result += 3 * (n - 2 * limit) * (n - 2 * limit - 1) / 2;
            }

            return (int)result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int n1 = 5;
            int limit1 = 2;
            int n2 = 3;
            int limit2 = 3;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.DistributeCandies(n1, limit1), 3),
                ResultTester.CheckResult<int>(Solution.DistributeCandies(n2, limit2), 10),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2928");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}