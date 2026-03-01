// Longest Balanced Subarray II
namespace CompetitiveProgramming.LeetCode.LongestBalancedSubarrayII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

#pragma warning disable CS8618

public class Solution
{
    private int[] treeMin;
    private int[] treeMax;
    private int[] lazy;
    private int n;

    public int LongestBalanced(int[] nums)
    {
        n = nums.Length;
        treeMin = new int[4 * n];
        treeMax = new int[4 * n];
        lazy = new int[4 * n];

        int[] lastPos = new int[100002];
        Array.Fill(lastPos, -1);

        int maxLen = 0;

        for (int r = 0; r < n; r++)
        {
            int val = nums[r];
            int prevIndex = lastPos[val];

            int diff = ((val & 1) == 0) ? 1 : -1;

            Update(1, 0, n - 1, prevIndex + 1, r, diff);

            lastPos[val] = r;

            int l = FindFirstZero(1, 0, n - 1);

            if (l != -1)
            {
                maxLen = Math.Max(maxLen, r - l + 1);
            }
        }

        return maxLen;
    }

    private void Push(int node)
    {
        if (lazy[node] != 0)
        {
            lazy[2 * node] += lazy[node];
            treeMin[2 * node] += lazy[node];
            treeMax[2 * node] += lazy[node];

            lazy[2 * node + 1] += lazy[node];
            treeMin[2 * node + 1] += lazy[node];
            treeMax[2 * node + 1] += lazy[node];

            lazy[node] = 0;
        }
    }

    private void Update(int node, int start, int end, int l, int r, int val)
    {
        if (l > end || r < start) return;

        if (l <= start && end <= r)
        {
            lazy[node] += val;
            treeMin[node] += val;
            treeMax[node] += val;
            return;
        }

        Push(node);
        int mid = (start + end) / 2;
        Update(2 * node, start, mid, l, r, val);
        Update(2 * node + 1, mid + 1, end, l, r, val);

        treeMin[node] = Math.Min(treeMin[2 * node], treeMin[2 * node + 1]);
        treeMax[node] = Math.Max(treeMax[2 * node], treeMax[2 * node + 1]);
    }

    private int FindFirstZero(int node, int start, int end)
    {
        if (treeMin[node] > 0 || treeMax[node] < 0) return -1;

        if (start == end)
        {
            return (treeMin[node] == 0) ? start : -1;
        }

        Push(node);
        int mid = (start + end) / 2;

        int res = FindFirstZero(2 * node, start, mid);
        if (res != -1) return res;

        return FindFirstZero(2 * node + 1, mid + 1, end);
    }
}

#pragma warning restore CS8618

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.LongestBalanced([2,5,4,3]), 4),
            ResultTester.CheckResult<int>(solution.LongestBalanced([3,2,2,5,4]), 5),
            ResultTester.CheckResult<int>(solution.LongestBalanced([1,2,3,2]), 3),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Longest Balanced Subarray II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}