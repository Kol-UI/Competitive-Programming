// Button with Longest Push Time
namespace CompetitiveProgramming.LeetCode.ButtonwithLongestPushTime;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int ButtonWithLongestTime(int[][] events)
    {
        int len = events.Length;
        if (len == 0)
            return 0;

        int longestTime = events[0][1], longestIdx = events[0][0], preEnd = events[0][1];

        for (int i = 1; i < len; i++)
        {
            int curTime = events[i][1], curIdx = events[i][0];
            int diff = curTime - preEnd;
            if (diff > longestTime)
            {
                longestIdx = curIdx;
                longestTime = diff;
            }
            else if (diff == longestTime && curIdx < longestIdx)
                longestIdx = curIdx;

            preEnd = curTime;
        }

        return longestIdx;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.ButtonWithLongestTime([[1,2],[2,5],[3,9],[1,15]]), 1),
            ResultTester.CheckResult<int>(solution.ButtonWithLongestTime([[10,5],[1,7]]), 10),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Button with Longest Push Time");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}