// Happy Students
namespace CompetitiveProgramming.LeetCode.HappyStudents;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountWays(IList<int> nums)
    {
        var list = new List<int>(nums);
        list.Sort();
        var result = 0;
        if (0 < list[0]) result++;
        for (int i = 0; i < list.Count - 1; i++)
        {
            var countSelected = i + 1;
            if (list[i] < countSelected && countSelected < list[i + 1]) result++;
        }
        if (list[list.Count - 1] < list.Count) result++;
        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Happy Students");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}