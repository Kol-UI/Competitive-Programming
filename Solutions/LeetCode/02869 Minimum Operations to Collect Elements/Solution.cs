// Minimum Operations to Collect Elements



using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumOperationstoCollectElements
{
    public class Solution
    {
        public static int MinOperations(IList<int> nums, int k)
        {
            var hashSet = new HashSet<int>();

            for (var i = nums.Count - 1; i >= 0; i--)
            {
                if (nums[i] <= k)
                {
                    hashSet.Add(nums[i]);

                    if (hashSet.Count == k)
                    {
                        return nums.Count - i;
                    }
                }
            }

            return nums.Count;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            IList<int> nums1 = new List<int> { 3, 1, 5, 4, 2 };
            int k1 = 2;

            IList<int> nums2 = new List<int> { 3, 1, 5, 4, 2 };
            int k2 = 5;

            IList<int> nums3 = new List<int> { 3, 2, 5, 3, 1 };
            int k3 = 3;

            IList<int> nums4 = new List<int> { 2, 4, 6, 8, 10 };
            int k4 = 7;

            IList<int> nums5 = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
            int k5 = 12;

            IList<int> nums6 = new List<int> { 5, 10, 15, 20, 25 };
            int k6 = 18;


            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinOperations(nums1, k1), 4),
                ResultTester.CheckResult<int>(Solution.MinOperations(nums2, k2), 5),
                ResultTester.CheckResult<int>(Solution.MinOperations(nums3, k3), 4),
                ResultTester.CheckResult<int>(Solution.MinOperations(nums4, k4), 5),
                ResultTester.CheckResult<int>(Solution.MinOperations(nums5, k5), 7),
                ResultTester.CheckResult<int>(Solution.MinOperations(nums6, k6), 5),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2869");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}