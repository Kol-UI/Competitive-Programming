// Count Paths That Can Form a Palindrome in a Tree
namespace CompetitiveProgramming.LeetCode.CountPathsThatCanFormaPalindromeinaTree;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    
    private Dictionary<int, long> freq = new Dictionary<int, long>();
    private int M = int.MaxValue;

    public long CountPalindromePaths(IList<int> parent, string s)
    {
        int n = parent.Count;
        int[] dp = new int[n];
        Array.Fill(dp, M);
        long ans = 0;

        for (int i = 0; i < parent.Count; i++)
        {
            int mask = F(i, parent, s, dp);
            for (int j = 0; j < 26; j++)
            {
                int mask_ = mask ^ (1 << j);
                if (freq.ContainsKey(mask_))
                {
                    ans += freq[mask_];
                }
            }
            if (freq.ContainsKey(mask))
            {
                ans += freq[mask];
            }
            if (!freq.ContainsKey(mask))
            {
                freq[mask] = 0;
            }
            freq[mask]++;
        }

        return ans;
    }

    private int F(int idx, IList<int> li, string s, int[] dp)
    {
        int c = idx, p = li[idx];
        if (p == -1) return 0;
        if (dp[c] != M) return dp[c];

        int mask = 1 << (s[c] - 'a');
        dp[c] = mask;
        dp[c] ^= F(p, li, s, dp);
        return dp[c];
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Paths That Can Form a Palindrome in a Tree");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}