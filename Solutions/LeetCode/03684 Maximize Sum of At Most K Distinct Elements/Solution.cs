// Maximize Sum of At Most K Distinct Elements
namespace CompetitiveProgramming.LeetCode.MaximizeSumofAtMostKDistinctElements;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] MaxKDistinct(int[] nums, int k) => nums.Distinct().OrderByDescending(m => m).Take(k).ToArray();
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int[]>(solution.MaxKDistinct([84,93,100,77,90], 3), [100,93,90]),
            ResultTester.CheckResult<int[]>(solution.MaxKDistinct([84,93,100,77,93], 3), [100,93,84]),
            ResultTester.CheckResult<int[]>(solution.MaxKDistinct([1,1,1,2,2,2], 6), [2,1]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximize Sum of At Most K Distinct Elements");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}