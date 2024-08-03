// Maximize Happiness of Selected Children

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximizeHappinessofSelectedChildren
{
    public class Solution
    {
        public static long MaximumHappinessSum(int[] happiness, int k)
        {
            Array.Sort(happiness);
            long result = 0;
            int turns = 0;

            for(int i = happiness.Length-1;i >= 0; i--)
            {
                if(k <= 0)
                    return result;

                happiness[i] = happiness[i] - turns;
                if(happiness[i] > 0)
                {
                    result += happiness[i];
                }

                turns++;
                k--;
            }
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(Solution.MaximumHappinessSum(new int[]{1,2,3}, 2), 4),
                ResultTester.CheckResult<long>(Solution.MaximumHappinessSum(new int[]{1,1,1,1}, 2), 1),
                ResultTester.CheckResult<long>(Solution.MaximumHappinessSum(new int[]{2,3,4,5}, 1), 5),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Maximize Happiness of Selected Children");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}