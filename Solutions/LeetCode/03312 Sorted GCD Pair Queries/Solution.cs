// Sorted GCD Pair Queries
namespace CompetitiveProgramming.LeetCode.SortedGCDPairQueries;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] GcdValues(int[] nums, long[] queries) {
        int m = nums.Max();
        long[] cnt = new long[m + 1];
        foreach (int num in nums) {
            cnt[num]++;
        }
        for (int i = 1; i <= m; i++) {
            for (int j = i * 2; j <= m; j += i) {
                cnt[i] += cnt[j];
            }
        }
        for (int i = 1; i <= m; i++) {
            cnt[i] = cnt[i] * (cnt[i] - 1) / 2;
        }
        for (int i = m; i >= 1; i--) {
            for (int j = i * 2; j <= m; j += i) {
                cnt[i] -= cnt[j];
            }
        }
        for (int i = 1; i <= m; i++) {
            cnt[i] += cnt[i - 1];
        }
        int[] ans = new int[queries.Length];
        for (int k = 0; k < queries.Length; k++) {
            long q = queries[k] + 1;
            int left = 1, right = m;
            while (left < right) {
                int mid = (left + right) / 2;
                if (cnt[mid] >= q) {
                    right = mid;
                } else {
                    left = mid + 1;
                }
            }
            ans[k] = left;
        }
        return ans;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sorted GCD Pair Queries");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}