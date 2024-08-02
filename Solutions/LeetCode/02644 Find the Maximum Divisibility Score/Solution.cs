// Find the Maximum Divisibility Score


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.FindtheMaximumDivisibilityScore
{
    public class Solution
    {
        public static int MaxDivScore(int[] nums, int[] divisors)
        {
            int maxScore = 0;
            int maxDivisor = int.MaxValue;
            
            foreach (int divisor in divisors)
            {
                int score = 0;
                foreach (int num in nums)
                {
                    if (num % divisor == 0)
                    {
                        score++;
                    }
                }
                if (score > maxScore)
                {
                    maxScore = score;
                    maxDivisor = divisor;
                }
                else if (score == maxScore)
                {
                    maxDivisor = Math.Min(maxDivisor, divisor);
                }
            }
            
            return maxDivisor;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MaxDivScore(new int[]{4,7,9,3,9}, new int[]{5,2,3}), 3),
                ResultTester.CheckResult<int>(Solution.MaxDivScore(new int[]{20,14,21,10}, new int[]{5,7,5}), 5),
                ResultTester.CheckResult<int>(Solution.MaxDivScore(new int[]{12}, new int[]{10,16}), 10),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2644");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}