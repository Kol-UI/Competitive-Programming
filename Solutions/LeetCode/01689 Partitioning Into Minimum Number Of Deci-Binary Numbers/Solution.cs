// Partitioning Into Minimum Number Of Deci-Binary Numbers
namespace CompetitiveProgramming.LeetCode.PartitioningIntoMinimumNumberOfDeciBinaryNumbers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinPartitions(string n) => n.ToCharArray().Max(m => m - '0');
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinPartitions("32"), 3),
            ResultTester.CheckResult<int>(solution.MinPartitions("82734"), 8),
            ResultTester.CheckResult<int>(solution.MinPartitions("27346209830709182346"), 9),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Partitioning Into Minimum Number Of Deci-Binary Numbers");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}