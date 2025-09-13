// Vowels Game in a String
namespace CompetitiveProgramming.LeetCode.VowelsGameinaString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool DoesAliceWin(string s)
    {
        string vowels = "aeiou";
        for(int i = 0;i < s.Length;i++)
            if(vowels.Contains(s[i]))
                return true;
        return false;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Vowels Game in a String");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}