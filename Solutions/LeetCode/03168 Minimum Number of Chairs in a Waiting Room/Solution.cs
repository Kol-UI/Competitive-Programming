// Minimum Number of Chairs in a Waiting Room
namespace CompetitiveProgramming.LeetCode.MinimumNumberofChairsinaWaitingRoom;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinimumChairs(string s)
    {

        int chair = 0, enter = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'E')
            {
                enter++;
                if (enter > chair)
                    chair++;
            }
            else
                enter--;
        }


        return chair;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinimumChairs("EEEEEEE"), 7),
            ResultTester.CheckResult<int>(solution.MinimumChairs("ELELEEL"), 2),
            ResultTester.CheckResult<int>(solution.MinimumChairs("ELEELEELLL"), 3),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Number of Chairs in a Waiting Room");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}