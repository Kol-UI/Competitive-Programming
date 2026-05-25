// Maximum Number of Pairs in Array
namespace CompetitiveProgramming.LeetCode.MaximumNumberofPairsinArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] NumberOfPairs(int[] nums)
    {
        int[] sample = new int[101];
        foreach (int cur in nums)
        {
            sample[cur]++;
        }

        int[] pairs = [0, 0];
        foreach (int cur in sample)
        {
            if (cur > 0)
            {
                pairs[0] += cur / 2;
                pairs[1] += cur % 2;
            }
        }

        return pairs;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int[]>(solution.NumberOfPairs([1,3,2,1,3,2,2]), [3,1]),
            ResultTester.CheckResult<int[]>(solution.NumberOfPairs([1,1]), [1,0]),
            ResultTester.CheckResult<int[]>(solution.NumberOfPairs([0]), [0,1]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Number of Pairs in Array");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}