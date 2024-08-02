// Apple Redistribution into Boxes


using System;
using System.Text;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.AppleRedistributionintoBoxes
{
    public class Solution
    {
        public static int MinimumBoxes(int[] apple, int[] capacity)
        {
            var sum = apple.Sum();
            capacity = capacity.OrderByDescending(p => p).ToArray();

            var currSum = 0;
            var index = 0;

            while (currSum < sum)
            {
                currSum += capacity[index];
                index++;
            }
            
            return index;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinimumBoxes(new int[]{1,3,2}, new int[]{4,3,1,5,2}), 2),
                ResultTester.CheckResult<int>(Solution.MinimumBoxes(new int[]{5,5,5}, new int[]{2,4,2,7}), 4),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Apple Redistribution into Boxes");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}