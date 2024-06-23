// Longest Continuous Subarray With Absolute Diff Less Than or Equal to Limit

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LongestContinuousSubarrayWithAbsoluteDiffLessThanorEqualtoLimit
{
    public class Solution
    {
        public static int LongestSubarray(int[] nums, int limit)
        {
            int rear = 0;
            int result = 0;
            SortedDictionary<int, int> st = new SortedDictionary<int, int>();

            for (int front = 0; front < nums.Length; front++)
            {
                if (!st.ContainsKey(nums[front]))
                    st[nums[front]] = 0;
                st[nums[front]]++;

                while (st.Count > 1 && st.Last().Key - st.First().Key > limit)
                {
                    st[nums[rear]]--;
                    if (st[nums[rear]] == 0)
                        st.Remove(nums[rear]);
                    rear++;
                }

                result = Math.Max(result, front - rear + 1);
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
                ResultTester.CheckResult<int>(Solution.LongestSubarray(new int[]{8,2,4,7}, 4), 2),
                ResultTester.CheckResult<int>(Solution.LongestSubarray(new int[]{10,1,2,4,7,2}, 5), 4),
                ResultTester.CheckResult<int>(Solution.LongestSubarray(new int[]{4,2,2,2,4,4,2,2}, 0), 3),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Longest Continuous Subarray With Absolute Diff Less Than or Equal to Limit");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}