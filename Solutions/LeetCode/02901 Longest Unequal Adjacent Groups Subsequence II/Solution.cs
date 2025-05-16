// Longest Unequal Adjacent Groups Subsequence II
namespace CompetitiveProgramming.LeetCode.LongestUnequalAdjacentGroupsSubsequenceII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {
     public IList<string> GetWordsInLongestSubsequence(string[] words, int[] groups)
 {
     int n = groups.Length;
     int[] dp = new int[n];
     int[] prev = new int[n];
     Array.Fill(dp, 1);
     Array.Fill(prev, -1);
     int maxIndex = 0;

     for (int i = 1; i < n; i++)
     {
         for (int j = 0; j < i; j++)
         {
             if (Check(words[i], words[j]) && dp[j] + 1 > dp[i] &&
                 groups[i] != groups[j])
             {
                 dp[i] = dp[j] + 1;
                 prev[i] = j;
             }
         }
         if (dp[i] > dp[maxIndex])
         {
             maxIndex = i;
         }
     }

     List<string> ans = new List<string>();
     for (int i = maxIndex; i >= 0; i = prev[i])
     {
         ans.Add(words[i]);
     }
     ans.Reverse();
     return ans;
 }

 private bool Check(string s1, string s2)
 {
     if (s1.Length != s2.Length)
     {
         return false;
     }
     int diff = 0;
     for (int i = 0; i < s1.Length; i++)
     {
         if (s1[i] != s2[i])
         {
             if (++diff > 1)
             {
                 return false;
             }
         }
     }
     return diff == 1;
 }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Longest Unequal Adjacent Groups Subsequence II");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}