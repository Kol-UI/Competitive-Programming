// Sum of Compatible Numbers in Range I
namespace CompetitiveProgramming.LeetCode.SumofCompatibleNumbersinRangeI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int SumOfGoodIntegers(int n, int k) => Enumerable.Range(n - k, (k * 2) + 1).Where(m => (m & n) == 0 && m > 0).Sum();
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.SumOfGoodIntegers(2, 3), 10),
            ResultTester.CheckResult<int>(solution.SumOfGoodIntegers(5, 1), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sum of Compatible Numbers in Range I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}