// Count Partitions with Even Sum Difference
namespace CompetitiveProgramming.LeetCode.CountPartitionswithEvenSumDifference;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int CountPartitions(int[] nums) => nums.Sum() % 2 == 0 ? nums.Length - 1 : 0;
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.CountPartitions([10,10,3,7,6]), 4),
            ResultTester.CheckResult<int>(solution.CountPartitions([1,2,2]), 0),
            ResultTester.CheckResult<int>(solution.CountPartitions([2,4,6,8]), 3),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Partitions with Even Sum Difference");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}