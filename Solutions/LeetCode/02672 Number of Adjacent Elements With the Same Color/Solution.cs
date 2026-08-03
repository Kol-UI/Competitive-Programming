// Number of Adjacent Elements With the Same Color
namespace CompetitiveProgramming.LeetCode.NumberofAdjacentElementsWiththeSameColor;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] ColorTheArray(int n, int[][] queries)
    {
        var result = new int[queries.Length];
        var nums = new int[n];
        nums[queries[0][0]] = queries[0][1];
        for (int i = 1; i < queries.Length; i++)
        {
            var shift = 0;
            if (nums[queries[i][0]] != 0)
            {
                if (0 < queries[i][0] && nums[queries[i][0] - 1] == nums[queries[i][0]]) shift--;
                if (queries[i][0] + 1 < nums.Length && nums[queries[i][0]] == nums[queries[i][0] + 1]) shift--;
            }
            nums[queries[i][0]] = queries[i][1];
            if (0 < queries[i][0] && nums[queries[i][0] - 1] == nums[queries[i][0]]) shift++;
            if (queries[i][0] + 1 < nums.Length && nums[queries[i][0]] == nums[queries[i][0] + 1]) shift++;
            result[i] = result[i - 1] + shift;
        }
        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int[]>(solution.ColorTheArray(4, [[0,2],[1,2],[3,1],[1,1],[2,1]]), [0,1,1,0,2]),
            ResultTester.CheckResult<int[]>(solution.ColorTheArray(1, [[0,100000]]), [0]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Number of Adjacent Elements With the Same Color");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}