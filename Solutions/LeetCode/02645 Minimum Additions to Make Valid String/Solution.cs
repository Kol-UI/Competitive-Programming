// Minimum Additions to Make Valid String
namespace CompetitiveProgramming.LeetCode.MinimumAdditionstoMakeValidString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int AddMinimum(string word)
    {
        var count = 0;
        var set = new HashSet<int>();
        for (var i = 0; i < word.Length; i++)
        {
            var curASC = word[i] - 'a';
            if (set.Count == 0 || curASC > set.Max())
                set.Add(curASC);
            else
            {
                count += 3 - set.Count;
                set.Clear();
                set.Add(curASC);
            }

            if (i == word.Length - 1 && set.Count > 0)
            {
                count += 3 - set.Count;
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
            ResultTester.CheckResult<int>(solution.AddMinimum("b"), 2),
            ResultTester.CheckResult<int>(solution.AddMinimum("aaa"), 6),
            ResultTester.CheckResult<int>(solution.AddMinimum("abc"), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Additions to Make Valid String");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}