// Third Maximum Number

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ThirdMaximumNumber
{
    public class Solution
    {
        public static int ThirdMax(int[] nums)
        {
            const int maxCount = 3;
            HashSet<int> uniqueNumbers = new HashSet<int>();

            foreach (int num in nums)
            {
                uniqueNumbers.Add(num);
                if (uniqueNumbers.Count > maxCount)
                {
                    uniqueNumbers.Remove(uniqueNumbers.Min());
                }
            }

            return uniqueNumbers.Count < maxCount ? uniqueNumbers.Max() : uniqueNumbers.Min();
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.ThirdMax(new int[]{3,2,1}), 1),
                ResultTester.CheckResult<int>(Solution.ThirdMax(new int[]{1,2}), 2),
                ResultTester.CheckResult<int>(Solution.ThirdMax(new int[]{2,2,3,1}), 1)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Third Maximum Number");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}