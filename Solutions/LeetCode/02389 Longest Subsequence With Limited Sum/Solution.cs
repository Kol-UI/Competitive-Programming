// Longest Subsequence With Limited Sum

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.LongestSubsequenceWithLimitedSum
{
    public class Solution
    {
        public static int[] AnswerQueries(int[] nums, int[] queries)
        {
            Array.Sort(nums);

            var result = new int[queries.Length];

            for (int i = 0; i < queries.Length; i++)
            {
                result[i] = GetQueryResult(nums, queries[i]);
            }

            return result;
        }

        private static int GetQueryResult(int[] nums, int query)
        {
            var result = 0;
            var sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum > query) break;
                result++;
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
                ResultTester.CheckResult<int[]>(Solution.AnswerQueries(new int[] {4,5,2,1}, new int[] {3,10,21}), new int[] {2,3,4}),
                ResultTester.CheckResult<int[]>(Solution.AnswerQueries(new int[] {2,3,4,5}, new int[] {1}), new int[] {0}),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2389");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}