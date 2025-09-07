// Find Mirror Score of a String
namespace CompetitiveProgramming.LeetCode.FindMirrorScoreofaString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long CalculateScore(string s)
    {
        var rs = 0L;
        var dic = new Dictionary<char, List<int>>();
        for (int i = 0; i < s.Length; i++)
        {
            var mirrorLetter = MirrorLetter(s[i]);
            if (dic.ContainsKey(mirrorLetter) && dic[mirrorLetter].Count > 0)
            {
                var lastIndex = dic[mirrorLetter][dic[mirrorLetter].Count - 1];
                rs += i - lastIndex;
                dic[mirrorLetter].RemoveAt(dic[mirrorLetter].Count - 1);
            }
            else
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic.Add(s[i], new List<int> { i });
                }
                else
                {
                    dic[s[i]].Add(i);
                }
            }
        }
        return rs;
    }

    private char MirrorLetter(char ch)
    {
        int shift = ch - 'a';
        var rs = (char)('z' - shift);
        return rs;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<long>(solution.CalculateScore("aczzx"), 5),
            ResultTester.CheckResult<long>(solution.CalculateScore("abcdef"), 0),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find Mirror Score of a String");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}