// Find the Key of the Numbers
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindtheKeyoftheNumbers
{
    public class Solution
    {
        public int GenerateKey(params int[] nums) =>
            new[] { 1, 10, 100, 1000 }.Sum(d => d * nums.Min(n => n / d % 10));
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.GenerateKey(1, 10, 1000), 0),
                ResultTester.CheckResult<int>(solution.GenerateKey(987, 879, 798), 777),
                ResultTester.CheckResult<int>(solution.GenerateKey(1, 2, 3), 1),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find the Key of the Numbers");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}