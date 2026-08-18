// Maximum Building Height
namespace CompetitiveProgramming.LeetCode.MaximumBuildingHeight;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxBuilding(int n, int[][] restrictions)
    {
        List<int[]> list = new List<int[]>();

        list.Add(new int[] { 1, 0 });

        foreach (var r in restrictions)
        {
            list.Add(new int[] { r[0], r[1] });
        }

        list.Sort((a, b) => a[0].CompareTo(b[0]));

        if (list[list.Count - 1][0] != n)
        {
            list.Add(new int[] { n, n - 1 });
        }

        for (int i = 1; i < list.Count; i++)
        {
            int distance = list[i][0] - list[i - 1][0];
            list[i][1] = Math.Min(list[i][1], list[i - 1][1] + distance);
        }
     
        for (int i = list.Count - 2; i >= 0; i--)
        {
            int distance = list[i + 1][0] - list[i][0];
            list[i][1] = Math.Min(list[i][1], list[i + 1][1] + distance);
        }

        int ans = 0;

        for (int i = 1; i < list.Count; i++)
        {
            int x1 = list[i - 1][0];
            int h1 = list[i - 1][1];

            int x2 = list[i][0];
            int h2 = list[i][1];

            int distance = x2 - x1;

            int maxHeight = (h1 + h2 + distance) / 2;

            ans = Math.Max(ans, maxHeight);
        }

        return ans;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MaxBuilding(5, [[2,1],[4,1]]), 2),
            ResultTester.CheckResult<int>(solution.MaxBuilding(6, []), 5),
            ResultTester.CheckResult<int>(solution.MaxBuilding(10, [[5,3],[2,5],[7,4],[10,3]]), 5),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Building Height");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}