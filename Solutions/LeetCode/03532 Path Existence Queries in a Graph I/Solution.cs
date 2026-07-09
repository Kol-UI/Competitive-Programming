// Path Existence Queries in a Graph I
namespace CompetitiveProgramming.LeetCode.PathExistenceQueriesinaGraphI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool[] PathExistenceQueries(int n, int[] nums, int maxDiff, int[][] queries)
    {
        int[] maxReachableIndices = new int[nums.Length];
        int maxReachable = nums.Length - 1;
        maxReachableIndices[maxReachable] = maxReachable;

        for (int i = nums.Length - 1; i >= 1; i--)
        {
            if (Math.Abs(nums[i] - nums[i - 1]) > maxDiff)
            {
                maxReachable = i - 1;
            }

            maxReachableIndices[i - 1] = maxReachable;
        }

        bool[] result = new bool[queries.Length];

        for (int i = 0; i < queries.Length; i++)
        {            
            int start = Math.Min(queries[i][0], queries[i][1]);
            int end = Math.Max(queries[i][0], queries[i][1]);
            result[i] = end <= maxReachableIndices[start];
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
            ResultTester.CheckResult<bool[]>(solution.PathExistenceQueries(2, [1,3], 1, [[0,0],[0,1]]), [true,false]),
            ResultTester.CheckResult<bool[]>(solution.PathExistenceQueries(4, [2,5,6,8], 2, [[0,1],[0,2],[1,3],[2,3]]), [false,false,true,true]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Path Existence Queries in a Graph I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}