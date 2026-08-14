// Words Within Two Edits of Dictionary
namespace CompetitiveProgramming.LeetCode.WordsWithinTwoEditsofDictionary;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public IList<string> TwoEditWords(string[] queries, string[] dictionary)
    {
        var ans = new List<string>();
        foreach (var query in queries)
        {
            foreach (var s in dictionary)
            {
                int dis = 0;
                for (int i = 0; i < query.Length; i++)
                {
                    if (query[i] != s[i])
                    {
                        dis++;
                    }
                }
                if (dis <= 2)
                {
                    ans.Add(query);
                    break;
                }
            }
        }
        return ans;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Words Within Two Edits of Dictionary");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}