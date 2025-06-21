// Minimum Deletions to Make String K-Special
namespace CompetitiveProgramming.LeetCode.MinimumDeletionstoMakeStringKSpecial;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinimumDeletions(string word, int k)
    {
        var dic = CreateDictionaryFromWord(word);
        var list = new List<int>();
        foreach(var item in dic)
        {
            list.Add(item.Value);
        }
        list.Sort();
        var rs = int.MaxValue;
        var sumOfLessValueItems = 0;
        for (int i = 0; i < list.Count; i++)
        {
            if (0 < i) sumOfLessValueItems += list[i - 1];
            var rs0 = sumOfLessValueItems;
            for (int j = i + 1; j < list.Count; j++)
            {
                if (list[j] - list[i] > k) rs0 += list[j] - list[i] - k;
            }
            rs = Math.Min(rs, rs0);
        }
        return rs;
    }
    private Dictionary<char, int> CreateDictionaryFromWord(string word)
    {
        var rs = new Dictionary<char, int>();
        for (int i = 0; i < word.Length; i++)
        {
            if (!rs.ContainsKey(word[i]))
            {
                rs.Add(word[i], 1);
            }
            else
            {
                rs[word[i]]++;
            }
        }
        return rs;
    }
}

public class TestSolution : BaseSolution
{
	public override void GetResult()
	{
        StyleHelper.Space();
        StyleHelper.Title("Minimum Deletions to Make String K-Special");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
	}
}