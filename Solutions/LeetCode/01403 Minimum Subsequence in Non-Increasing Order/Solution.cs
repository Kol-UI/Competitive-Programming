// Minimum Subsequence in Non-Increasing Order

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumSubsequenceinNonIncreasingOrder
{
    public class Solution
    {
        public IList<int> MinSubsequence(int[] nums)
        {
            int halfSum = nums.Sum() / 2;
            var subsequence = new List<int>();
            int currentSum = 0;

            foreach (var num in nums.OrderByDescending(n => n))
            {
                currentSum += num;
                subsequence.Add(num);

                if (currentSum > halfSum)
                {
                    break;
                }
            }

            return subsequence;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Minimum Subsequence in Non-Increasing Order");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}