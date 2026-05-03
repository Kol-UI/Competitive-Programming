// Count Items Matching a Rule
namespace CompetitiveProgramming.LeetCode.CountItemsMatchingaRule;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
    {
        int count = 0;
        var a = new Dictionary<string, int>
        {
            {"type",0},{"color",1},{"name",2}
        };
        int f = 0;
        foreach (var i in a.Keys)
        {
            if (i.Equals(ruleKey))
            {
                f = a[i];
                break;
            }
        }
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i][f] == ruleValue)
            {
                count++;
            }
        }
        return count;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.CountMatches([["phone","blue","pixel"],["computer","silver","lenovo"],["phone","gold","iphone"]], "color", "silver"), 1),
            ResultTester.CheckResult<int>(solution.CountMatches([["phone","blue","pixel"],["computer","silver","phone"],["phone","gold","iphone"]], "type", "phone"), 2),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Items Matching a Rule");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}