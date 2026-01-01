// Check if the Sentence Is Pangram
namespace CompetitiveProgramming.LeetCode.CheckiftheSentenceIsPangram;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool CheckIfPangram(string sentence)
    {
        HashSet<char> characters = new HashSet<char>(sentence);
        return characters.Count == 26;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check if the Sentence Is Pangram");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}