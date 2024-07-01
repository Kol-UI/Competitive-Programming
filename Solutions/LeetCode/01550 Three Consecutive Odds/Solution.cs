// Three Consecutive Odds

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ThreeConsecutiveOdds
{   
    public class Solution
    {
        public static bool ThreeConsecutiveOdds(int[] arr)
        {
            int window = 0;
            for (int i = 0; i < 3 && i < arr.Length; i++)
            {
                window += arr[i] % 2;
            }
            if (window == 3)
            {
                return true;
            }
            for (int i = 3; i < arr.Length; i++)
            {
                window += arr[i] % 2;
                window -= arr[i - 3] % 2;
                if (window == 3)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(Solution.ThreeConsecutiveOdds(new int[]{2,6,4,1}), false),
                ResultTester.CheckResult<bool>(Solution.ThreeConsecutiveOdds(new int[]{1,2,34,3,4,5,7,23,12}), true)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Three Consecutive Odds");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}