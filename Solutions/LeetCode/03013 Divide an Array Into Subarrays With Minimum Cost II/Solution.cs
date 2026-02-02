// Divide an Array Into Subarrays With Minimum Cost II
namespace CompetitiveProgramming.LeetCode.DivideanArrayIntoSubarraysWithMinimumCostII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

public class Solution
{
    public long MinimumCost(int[] nums, int k, int dist)
    {
        int n = nums.Length;
        long ans = long.MaxValue;

        var small = new PriorityQueue<int, int>();
        var large = new PriorityQueue<int, int>();

        var delayed = new Dictionary<int, int>();

        int sizeSmall = 0;
        long sumSmall = 0;

        void Prune(PriorityQueue<int, int> heap)
        {
            while (heap.Count > 0)
            {
                int x = heap.Peek();
                if (!delayed.ContainsKey(x)) break;
                if (--delayed[x] == 0) delayed.Remove(x);
                heap.Dequeue();
            }
        }

        void Balance()
        {
            Prune(small);
            Prune(large);

            while (sizeSmall > k - 1)
            {
                int x = small.Dequeue();
                sumSmall -= x;
                sizeSmall--;
                large.Enqueue(x, x);
                Prune(small);
            }

            while (sizeSmall < k - 1 && large.Count > 0)
            {
                int x = large.Dequeue();
                sumSmall += x;
                sizeSmall++;
                small.Enqueue(x, -x);
                Prune(large);
            }
        }

        void Add(int x)
        {
            if (sizeSmall == 0 || x <= small.Peek())
            {
                small.Enqueue(x, -x);
                sumSmall += x;
                sizeSmall++;
            }
            else
            {
                large.Enqueue(x, x);
            }
            Balance();
        }

        void Remove(int x)
        {
            delayed[x] = delayed.GetValueOrDefault(x) + 1;

            if (x <= small.Peek())
            {
                sumSmall -= x;
                sizeSmall--;
            }
            Balance();
        }

        for (int i = 1; i <= dist + 1; i++)
            Add(nums[i]);

        ans = nums[0] + sumSmall;

        for (int i = dist + 2; i < n; i++)
        {
            Remove(nums[i - (dist + 1)]);
            Add(nums[i]);
            ans = Math.Min(ans, nums[0] + sumSmall);
        }

        return ans;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<long>(solution.MinimumCost([1,3,2,6,4,2], 3, 3), 5),
            ResultTester.CheckResult<long>(solution.MinimumCost([10,8,18,9], 3, 1), 36),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Divide an Array Into Subarrays With Minimum Cost II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}