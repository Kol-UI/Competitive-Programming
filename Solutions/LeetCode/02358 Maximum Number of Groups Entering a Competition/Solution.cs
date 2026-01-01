// Maximum Number of Groups Entering a Competition
namespace CompetitiveProgramming.LeetCode.MaximumNumberofGroupsEnteringaCompetition;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaximumGroups(int[] grades)
    {
        var totalGroups = 1;
        var studentSize = grades.Length;
        var studentsInLastGroup = 1;
        var groupHeadCount = 1;

        while (studentsInLastGroup + groupHeadCount < studentSize)
        {
            groupHeadCount++;
            studentsInLastGroup += groupHeadCount;
            totalGroups++;
        }

        return totalGroups;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Number of Groups Entering a Competition");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}