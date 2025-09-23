// Count Common Words With One Occurrence
namespace CompetitiveProgramming.LeetCode.CountCommonWordsWithOneOccurrence;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountWords(string[] words1, string[] words2)
    {
        var uniqueWords1 = words1.ToLookup(x => x).Where(x => x.Count() == 1).Select(x => x.Key);
        var uniqueWords2 = words2.ToLookup(x => x).Where(x => x.Count() == 1).Select(x => x.Key);
        return uniqueWords1.Intersect(uniqueWords2).Count();
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Common Words With One Occurrence");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}