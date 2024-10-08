// Minimum Number of Swaps to Make the String Balanced

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumNumberofSwapstoMaketheStringBalanced
{
    public class Solution
    {
        public int MinSwaps(string s)
        {
            int result = 0;
            foreach(char c in s)
            {
                if(c == '[')
                {
                    result++;
                }
                else if(result > 0)
                {
                    result--;
                }
            }
            return (result + 1) / 2;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            var solution = new Solution();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.MinSwaps("][]["), 1),
                ResultTester.CheckResult<int>(solution.MinSwaps("]]][[["), 2),
                ResultTester.CheckResult<int>(solution.MinSwaps("[]"), 0)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Number of Swaps to Make the String Balanced");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}