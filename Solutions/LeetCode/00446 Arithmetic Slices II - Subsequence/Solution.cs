// Arithmetic Slices II - Subsequence



using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.ArithmeticSlicesIISubsequence
{
    public class Solution
    {
        private static int Greater(IList<int> items, int target)
        {
            var start = 0;
            var end = items.Count - 1;

            while (start <= end)
            {
                var mid = start + (end - start) / 2;
                if (items[mid] <= target)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }

            return end + 1;
        }

        private static int Solve(int[] nums, Dictionary<int, List<int>> map, int prev, int index, int[][] memo)
        {
            if (index >= nums.Length)
            {
                return 0;
            }
            if (memo[prev][index] >= 0)
            {
                return memo[prev][index];
            }

            var count = 0;
            long target = nums[index];

            target -= nums[prev];
            target += nums[index];

            if ((target <= int.MaxValue) && (target >= int.MinValue) && map.TryGetValue((int)target, out var indexes))
            {
                var next = Greater(indexes, index);
                for (var i = next; i < indexes.Count; i += 1)
                {
                    count += Solve(nums, map, index, indexes[i], memo) + 1;
                }
            }
            memo[prev][index] = count;

            return count;
        }

        public static int NumberOfArithmeticSlices(int[] nums)
        {
            var map = new Dictionary<int, List<int>>();

            for (var i = 0; i < nums.Length; i += 1)
            {
                if (map.TryGetValue(nums[i], out var indexes))
                {
                    indexes.Add(i);
                }
                else
                {
                    map.Add(nums[i], new() { i });
                }
            }

            var memo = new int[nums.Length][];

            for (var i = 0; i < memo.Length; i += 1)
            {
                memo[i] = new int[nums.Length];
                Array.Fill(memo[i], -1);
            }

            var count = 0;
            
            for (var i = 0; i < nums.Length - 2; i += 1)
            {
                for (var j = i + 1; j < nums.Length - 1; j += 1)
                {
                    count += Solve(nums, map, i, j, memo);
                }
            }
            
            return count;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.NumberOfArithmeticSlices(new int[] {2,4,6,8,10}), 7),
                ResultTester.CheckResult<int>(Solution.NumberOfArithmeticSlices(new int[] {7,7,7,7,7}), 16),
            };
            return results;
        }
    }
}