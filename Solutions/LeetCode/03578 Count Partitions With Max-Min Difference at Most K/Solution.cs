// Count Partitions With Max-Min Difference at Most K
namespace CompetitiveProgramming.LeetCode.CountPartitionsWithMaxMinDifferenceatMostK;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountPartitions(int[] nums, int k)
    {
        int mod = (int)Math.Pow(10, 9) + 7;
        int n = nums.Length;
        int[] dp = new int[n + 1];
        int[] prefix = new int[n + 2];

        dp[0] = 1;
        prefix[1] = 1;

        PriorityQueue<(int value, int index), int> smallest = new PriorityQueue<(int, int), int>();
        PriorityQueue<(int value, int index), int> largest = new PriorityQueue<(int, int), int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        int left = 0;

        for (int r = 0; r < n; r++)
        {
            smallest.Enqueue((nums[r], r), nums[r]);
            largest.Enqueue((nums[r], r), nums[r]);

            int diff = largest.Peek().value - smallest.Peek().value;

            while (diff > k)
            {
                left++;
                while (smallest.Count > 0 && smallest.Peek().index < left)
                {
                    smallest.Dequeue();
                }
                while (largest.Count > 0 && largest.Peek().index < left)
                {
                    largest.Dequeue();
                }

                diff = largest.Peek().value - smallest.Peek().value;
            }

            dp[r + 1] = (prefix[r + 1] - prefix[left] + mod) % mod;
            prefix[r + 2] = (prefix[r + 1] + dp[r + 1]) % mod;
        }

        return dp[n];
    }
}

public class Solution2
{
    public int CountPartitions(int[] nums, int k)
    {
        int mod = 1000000007;
        int n = nums.Length;
        int[] dp = new int[n + 1];
        int[] prefix = new int[n + 2];

        dp[0] = 1;
        prefix[1] = 1;

        var minHeap = new PriorityQueue<(int val, int idx), int>();
        var maxHeap = new PriorityQueue<(int val, int idx), int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

        int left = 0;

        for (int right = 0; right < n; right++)
        {
            minHeap.Enqueue((nums[right], right), nums[right]);
            maxHeap.Enqueue((nums[right], right), nums[right]);

            int diff = maxHeap.Peek().val - minHeap.Peek().val;

            while (diff > k)
            {
                left++;
                while (minHeap.Count > 0 && minHeap.Peek().idx < left) minHeap.Dequeue();
                while (maxHeap.Count > 0 && maxHeap.Peek().idx < left) maxHeap.Dequeue();
                diff = maxHeap.Peek().val - minHeap.Peek().val;
            }

            dp[right + 1] = (prefix[right + 1] - prefix[left] + mod) % mod;
            prefix[right + 2] = (prefix[right + 1] + dp[right + 1]) % mod;
        }

        return dp[n];
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        Solution2 solution2 = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.CountPartitions([9,4,1,3,7], 4), 6),
            ResultTester.CheckResult<int>(solution.CountPartitions([3,3,4], 0), 2),
            ResultTester.CheckResult<int>(solution2.CountPartitions([9,4,1,3,7], 4), 6),
            ResultTester.CheckResult<int>(solution2.CountPartitions([3,3,4], 0), 2),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Partitions With Max-Min Difference at Most K");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}