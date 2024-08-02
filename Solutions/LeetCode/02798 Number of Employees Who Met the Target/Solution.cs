// Number of Employees Who Met the Target

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.NumberofEmployeesWhoMettheTarget
{
    public static class Solution
    {
        public static int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
        {
            int i = 0;

            foreach (int hour in hours)
            {
                if (hour >= target)
                {
                    i++;
                }
            }

            return i;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.NumberOfEmployeesWhoMetTarget(new int[] {0,1,2,3,4}, 2), 3),
                ResultTester.CheckResult<int>(Solution.NumberOfEmployeesWhoMetTarget(new int[] {5,1,4,2,2}, 6), 0),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2798");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}