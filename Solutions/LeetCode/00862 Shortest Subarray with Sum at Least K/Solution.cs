// Shortest Subarray with Sum at Least K

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.ShortestSubarraywithSumatLeastK
{
    public class Solution
    {
        public int ShortestSubarray(int[] nums, int k)
        {
            var result = Int32.MaxValue;
            var tempo = 0L;
            var queue = new PriorityQueue<(long, int), long>();

            for (int i = 0; i < nums.Length; i++)
            {
                tempo += nums[i];

                if (tempo >= k)
                {
                    result = Math.Min(result, i + 1);
                }

                while (queue.Count > 0 && tempo - queue.Peek().Item1 >= k)
                {
                    var previous = queue.Dequeue().Item2;
                    result = Math.Min(result, i - previous);
                }

                queue.Enqueue((tempo, i), tempo);
            }

            if (result == Int32.MaxValue) return -1;
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(solution.ShortestSubarray(new int[]{1}, 1), 1),
                ResultTester.CheckResult<int>(solution.ShortestSubarray(new int[]{1, 2}, 4), -1),
                ResultTester.CheckResult<int>(solution.ShortestSubarray(new int[]{2, -1, 2}, 3), 3),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Shortest Subarray with Sum at Least K");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}