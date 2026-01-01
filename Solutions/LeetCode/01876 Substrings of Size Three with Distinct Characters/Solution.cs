// Substrings of Size Three with Distinct Characters
namespace CompetitiveProgramming.LeetCode.SubstringsofSizeThreewithDistinctCharacters;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountGoodSubstrings(string s)
    {
        var result = 0;
        for(int i = 0;i < s.Length-2;i++)
        {
            if(s[i] != s[i+1] && s[i+1] != s[i+2] && s[i+2] != s[i])
            {
                result++;
            }
        }
        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Substrings of Size Three with Distinct Characters");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}