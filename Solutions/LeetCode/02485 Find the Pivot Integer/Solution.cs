// Find the Pivot Integer


using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindthePivotInteger
{
    public class Solution
    {
        public static int PivotInteger(int n)
        {
            var sumLeftToRight = new int[n];
            var sumRightToLeft = new int[n];

            sumLeftToRight[0] = 1;
            sumRightToLeft[n-1] = n;

            for(int k = 1; k < n; k++)
            {
                sumLeftToRight[k] = sumLeftToRight[k-1] + k + 1;
                sumRightToLeft[n-1-k] = (n-k) + sumRightToLeft[n-k];
            }

            for(int h = 0; h < n; h++)
            {
                if(sumLeftToRight[h] == sumRightToLeft[h])
                    return h + 1;
            }
            return -1;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.PivotInteger(8), 6),
                ResultTester.CheckResult<int>(Solution.PivotInteger(1), 1),
                ResultTester.CheckResult<int>(Solution.PivotInteger(4), -1),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2485");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}