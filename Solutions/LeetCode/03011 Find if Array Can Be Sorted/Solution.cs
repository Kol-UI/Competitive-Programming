// Find if Array Can Be Sorted

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindifArrayCanBeSorted
{
    public class Solution
    {
        public bool CanSortArray(int[] nums)
        {
            var previousMax = 0;
            var currentMax = nums[0];
            var currentMin = nums[0];
            var previousBitCount = CountBits(nums[0]);
            
            for (int i = 1; i < nums.Length; i++)
            {
                var currentBitCount = CountBits(nums[i]);
                
                if (previousBitCount == currentBitCount)
                {
                    currentMax = Math.Max(currentMax, nums[i]);
                    currentMin = Math.Min(currentMin, nums[i]);
                }
                else
                {
                    if (previousMax > currentMin) return false;
                    previousBitCount = currentBitCount;
                    previousMax = currentMax;
                    currentMax = nums[i];
                    currentMin = nums[i];
                }
            }
            
            if (previousMax > currentMin) return false;
            return true;
        }

        private int CountBits(int n)
        {
            int bitCount = 0;
            while (n > 0)
            {
                bitCount += n % 2;
                n /= 2;
            }
            return bitCount;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool>(solution.CanSortArray(new int[]{8,4,2,30,15}), true),
                ResultTester.CheckResult<bool>(solution.CanSortArray(new int[]{1,2,3,4,5}), true),
                ResultTester.CheckResult<bool>(solution.CanSortArray(new int[]{3,16,8,4,2}), false)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Find if Array Can Be Sorted");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}