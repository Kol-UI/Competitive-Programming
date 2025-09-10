// Minimum Number of People to Teach
namespace CompetitiveProgramming.LeetCode.MinimumNumberofPeopletoTeach;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinimumTeachings(int n, int[][] languages, int[][] friendships)
    {
        var dicLang = CreateDicOfLanguages(languages);
        var set = new HashSet<int>();
        for (int i = 0; i < friendships.Length; i++)
        {
            if ((dicLang[friendships[i][0]].Intersect(dicLang[friendships[i][1]])).Count() == 0)
            {
                set.Add(friendships[i][0]);
                set.Add(friendships[i][1]);
            }
        }
        var dic = new Dictionary<int, int>();
        var maxLang = 0;
        foreach (var item in set)
        {
            foreach (var lang in dicLang[item])
            {
                if (!dic.ContainsKey(lang)) dic.Add(lang, 0);
                dic[lang]++;
                maxLang = Math.Max(maxLang, dic[lang]);
            }
        }
        var rs = set.Count - maxLang;
        return rs;
    }

    private Dictionary<int, HashSet<int>> CreateDicOfLanguages(int[][] languages)
    {
        var rs = new Dictionary<int, HashSet<int>>();
        for (int i = 0; i < languages.Length; i++)
        {
            rs.Add(i + 1, new HashSet<int>(languages[i]));
        }
        return rs;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Number of People to Teach");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}