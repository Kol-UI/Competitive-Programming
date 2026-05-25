// Substring Matching Pattern
namespace CompetitiveProgramming.LeetCode.SubstringMatchingPattern;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {
    public bool HasMatch(string s, string p)
    {       
        int strPos =0, patternPos =0, startPatternPos = 0;

        for (int i = 0; i < 2; i++)
        {
            patternPos = startPatternPos; 
            while (strPos + patternPos < s.Length)
            {                    
                if (p[patternPos] == '*')
                {
                    if (patternPos == p.Length - 1)
                    {
                        return true;
                    }
                    strPos-- ;
                    break;
                }
                if (s[strPos + patternPos] == p[patternPos])
                {
                    patternPos++;
                    if (patternPos == p.Length)
                    {
                        return true;
                    }
                    if (patternPos == (p.Length-1) && p[patternPos]=='*')
                    {
                        return true ;
                    }
                    continue;
                }
                strPos++;
                patternPos = startPatternPos;
            }
            if (strPos + patternPos >= s.Length)
            {
                return false;
            }
            startPatternPos = patternPos + 1;
        }
        return false;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.HasMatch("leetcode", "ee*e"), true),
            ResultTester.CheckResult<bool>(solution.HasMatch("luck", "u*"), true),
            ResultTester.CheckResult<bool>(solution.HasMatch("car", "c*v"), false),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Substring Matching Pattern");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}