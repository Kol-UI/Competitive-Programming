// Bitwise OR of Even Numbers in an Array
namespace CompetitiveProgramming.LeetCode.BitwiseORofEvenNumbersinanArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int EvenNumberBitwiseORs(int[] nums)
        => nums.Where(m => m % 2 == 0).Aggregate(0, (sum, current) =>
            {
                return sum | current;
            });
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.EvenNumberBitwiseORs([1,2,3,4,5,6]), 6),
            ResultTester.CheckResult<int>(solution.EvenNumberBitwiseORs([7,9,11]), 0),
            ResultTester.CheckResult<int>(solution.EvenNumberBitwiseORs([1,8,16]), 24),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Bitwise OR of Even Numbers in an Array");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}