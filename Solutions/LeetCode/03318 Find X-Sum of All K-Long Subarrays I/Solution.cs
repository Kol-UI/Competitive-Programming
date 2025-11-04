// Find X-Sum of All K-Long Subarrays I
namespace CompetitiveProgramming.LeetCode.FindXSumofAllKLongSubarraysI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

public class Solution
{
    public int[] FindXSum(int[] nums, int k, int x)
    {
        int n = nums.Length;
        int[] ans = new int[n - k + 1];

        for (int i = 0; i + k <= n; i++)
        {
            int[] cnt = new int[51];
            for (int j = i; j < i + k; j++)
                cnt[nums[j]]++;

            var list = new List<(int val, int cnt)>();
            for (int v = 1; v <= 50; v++)
                if (cnt[v] > 0)
                    list.Add((v, cnt[v]));

            list.Sort((a, b) =>
            {
                int cmp = b.cnt.CompareTo(a.cnt);
                if (cmp != 0) return cmp;
                return b.val.CompareTo(a.val);
            });

            int take = Math.Min(x, list.Count);
            int sum = 0;
            for (int t = 0; t < take; t++)
                sum += list[t].val * list[t].cnt;

            ans[i] = sum;
        }

        return ans;
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find X-Sum of All K-Long Subarrays I");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}