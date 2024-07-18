// Find the Integer Added to Array I

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindtheIntegerAddedtoArrayI
{
    public class Solution
    {
        public static int AddedInteger(int[] nums1, int[] nums2)
        {
            return (nums2.Sum() - nums1.Sum()) / nums1.Length;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.AddedInteger(new int[]{2,6,4}, new int[]{9,7,5}), 3),
                ResultTester.CheckResult<int>(Solution.AddedInteger(new int[]{10}, new int[]{5}), -5),
                ResultTester.CheckResult<int>(Solution.AddedInteger(new int[]{1,1,1,1}, new int[]{1,1,1,1}), 0),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Title");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}