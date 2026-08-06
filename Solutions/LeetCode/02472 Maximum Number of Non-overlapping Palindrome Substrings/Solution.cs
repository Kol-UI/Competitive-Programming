// Maximum Number of Non-overlapping Palindrome Substrings
namespace CompetitiveProgramming.LeetCode.MaximumNumberofNonoverlappingPalindromeSubstrings;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxPalindromes(string s, int k)
    {
        Dictionary<char,List<int>> D = new();
        int start = 0;
        int res = 0;
        int end = k-1;
        while(end<s.Length)
        {
            if(FindP(start, end, s,k))
            {
                start = end+1;
                end = start + k - 1;
                res++;
            }
            else
                end++;
                
        }
        
        return res;
        
    }
    
    public bool FindP(int start, int end, string s, int k)
    {
        for(int i=end-k+1;i>=start;i--)
        {
            if(IsP(i, end, s)) return true;
        }
        return false;
    }
    public bool IsP(int start, int end, string s)
    {
        while(start<end)
        {
            if(s[start++]!=s[end--])
                return false;
        }
        return true;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MaxPalindromes("abaccdbbd", 3), 2),
            ResultTester.CheckResult<int>(solution.MaxPalindromes("adbcda", 2), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Number of Non-overlapping Palindrome Substrings");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}