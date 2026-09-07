// Distinct Subsequences II
namespace CompetitiveProgramming.LeetCode.DistinctSubsequencesII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    private int modulo = 1000000007;

    public int DistinctSubseqII(string s)
    {
        int[] map = new int[26];
        foreach(char ch in s)
        {
            int ind = ch - 'a';
            map[ind] = (map[ind] + 1) % modulo;
            for(int i = 0; i < 26; i++)
                if(i != ind)
                    map[ind] = (map[ind] + map[i]) % modulo;
        }
        int result = 0;
        for(int i = 0; i < 26; i++)
            result = (result + map[i]) % modulo;
        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.DistinctSubseqII("abc"), 7),
            ResultTester.CheckResult<int>(solution.DistinctSubseqII("aba"), 6),
            ResultTester.CheckResult<int>(solution.DistinctSubseqII("aaa"), 3),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Distinct Subsequences II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}