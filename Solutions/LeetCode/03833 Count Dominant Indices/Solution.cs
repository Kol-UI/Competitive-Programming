// Count Dominant Indices
namespace CompetitiveProgramming.LeetCode.CountDominantIndices;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int DominantIndices(int[] nums)
    {
        int len = nums.Length, tailSum = nums[len - 1], result = 0;

        for(int i = len - 2; i >= 0; i--)
        {
            int current = nums[i];
            if(current * (len - i - 1) > tailSum)
                result++;

            tailSum += current;
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
            ResultTester.CheckResult<int>(solution.DominantIndices([5,4,3]), 2),
            ResultTester.CheckResult<int>(solution.DominantIndices([4,1,2]), 1)
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Dominant Indices");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}