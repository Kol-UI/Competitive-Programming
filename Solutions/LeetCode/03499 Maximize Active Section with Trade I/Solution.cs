// Maximize Active Section with Trade I
namespace CompetitiveProgramming.LeetCode.MaximizeActiveSectionwithTradeI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxActiveSectionsAfterTrade(string s)
    {
        var (list, totalActiveSection) = CalculateAux(s);
        if (list.Count <= 2) return totalActiveSection;
        if (list.Count == 3) return s[0] == '0' ? s.Length : totalActiveSection;
        var rs = 0;
        for (int i = s[0] == '0' ? 1 : 2; i < list.Count; i += 2)
        {
            var rs0 = list[i - 1];
            if (i + 1 < list.Count) rs0 += list[i + 1];
            rs = Math.Max(rs, rs0 + totalActiveSection);
        }
        return rs;
    }
    private (List<int> list, int activeSections) CalculateAux(string s)
    {
        var list = new List<int> { 1 };
        var activeSections = s[0] == '0' ? 0 : 1;
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i - 1] == s[i])
            {
                list[list.Count - 1]++;
            }
            else
            {
                list.Add(1);
            }
            if (s[i] == '1') activeSections++;
        }
        return (list, activeSections);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MaxActiveSectionsAfterTrade("01"), 1),
            ResultTester.CheckResult<int>(solution.MaxActiveSectionsAfterTrade("0100"), 4),
            ResultTester.CheckResult<int>(solution.MaxActiveSectionsAfterTrade("1000100"), 7),
            ResultTester.CheckResult<int>(solution.MaxActiveSectionsAfterTrade("01010"), 4),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximize Active Section with Trade I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}