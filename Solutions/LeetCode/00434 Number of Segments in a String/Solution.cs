// Number of Segments in a String
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.NumberofSegmentsinaString
{
    public class Solution
    {
        public int CountSegments(string s)
        {
            int segments = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsWhiteSpace(s[i]) && (i == 0 || char.IsWhiteSpace(s[i - 1])))
                {
                    segments++;
                }
            }

            return segments;
        }
    }


    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.CountSegments("Hello, my name is John"), 5),
                ResultTester.CheckResult<int>(solution.CountSegments("Hello"), 1)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Number of Segments in a String");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}