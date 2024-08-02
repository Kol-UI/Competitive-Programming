// Sum of Values at Indices With K Set Bits



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.SumofValuesatIndicesWithKSetBits
{
    public class Solution
    {
        public static int SumIndicesWithKSetBits(IList<int> nums, int k)
        {
            var result = 0;

            if (k == 0)
            {
                return nums[0];
            }

            for (int i = 0; i < nums.Count; i++)
            {
                if (Convert.ToString(i, 2).Count(c => c == '1') == k)
                {
                    result += nums[i];
                }
            }

            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            IList<int> nums1 = new List<int> { 5, 10, 1, 5, 2 };
            int k1 = 1;
            int expectedResult1 = 13;

            IList<int> nums2 = new List<int> { 4, 3, 2, 1 };
            int k2 = 2;
            int expectedResult2 = 1;

            IList<int> nums3 = new List<int> { 8, 2, 3, 4 };
            int k3 = 0;
            int expectedResult3 = 8;

            IList<int> nums4 = new List<int> { 7, 15, 3, 5, 6 };
            int k4 = 3;
            int expectedResult4 = 0;

            IList<int> nums5 = new List<int> { 2, 4, 8 };
            int k5 = 5;
            int expectedResult5 = 0;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.SumIndicesWithKSetBits(nums1, k1), expectedResult1),
                ResultTester.CheckResult<int>(Solution.SumIndicesWithKSetBits(nums2, k2), expectedResult2),
                ResultTester.CheckResult<int>(Solution.SumIndicesWithKSetBits(nums3, k3), expectedResult3),
                ResultTester.CheckResult<int>(Solution.SumIndicesWithKSetBits(nums4, k4), expectedResult4),
                ResultTester.CheckResult<int>(Solution.SumIndicesWithKSetBits(nums5, k5), expectedResult5),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2859");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}