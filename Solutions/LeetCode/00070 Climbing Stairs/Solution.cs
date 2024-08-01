using System;
using System.Threading;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ClimbingStairs
{
	public class Solution
	{
        //Example 1
        //Input: n = 2
        //Output: 2
        //Explanation: There are two ways to climb to the top.
        //1. 1 step + 1 step
        //2. 2 steps

        //Example 2
        //Input: n = 3
        //Output: 3
        //Explanation: There are three ways to climb to the top.
        //1. 1 step + 1 step + 1 step
        //2. 1 step + 2 steps
        //3. 2 steps + 1 step

        public static int ClimbStairs(int n)
        {
            int a = 0, b = 1, c = 0;
            for (int i = 0; i < n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }
	}

    public class Test
    {
        public static bool[] TestClimbingStairs()
        {
            // Case 1
            int Case1_70 = Solution.ClimbStairs(2);

            // Case 2
            int Case2_70 = Solution.ClimbStairs(3);

            // Case 3
            int Case3_70 = Solution.ClimbStairs(40);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Case1_70, 2),
                ResultTester.CheckResult<int>(Case2_70, 3),
                ResultTester.CheckResult<int>(Case3_70, 165580141),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Climbing Stairs");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestClimbingStairs());
        }
    }
}