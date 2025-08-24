// Consecutive Characters
namespace CompetitiveProgramming.LeetCode.ConsecutiveCharacters;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxPower(string s)
    {
        int count = 1;
        int max = int.MinValue;
        for(int i = 1; i < s.Length; i++)
        {
            if(s[i] == s[i-1])
            {
                count++;
            }
            if(s[i] != s[i-1] || i+1 == s.Length)
            {
                if(max < count)
                {
                    max = count;
                }
                count = 1;
            }
        }
        if(max == int.MinValue) return 1;
        else return max;
    }
}


public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MaxPower("leetcode"), 2),
            ResultTester.CheckResult<int>(solution.MaxPower("abbcccddddeeeeedcba"), 5)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Consecutive Characters");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}