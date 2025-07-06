// Remove All Occurrences of a Substring

namespace CompetitiveProgramming.LeetCode.RemoveAllOccurrencesofaSubstring;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string RemoveOccurrences(string s, string part) 
    {
        while(s.Contains(part))
            s = s.Remove(s.IndexOf(part), part.Length);
        return s;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Remove All Occurrences of a Substring");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}