// Neighboring Bitwise XOR
namespace CompetitiveProgramming.LeetCode.NeighboringBitwiseXOR;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool DoesValidArrayExist(int[] derived)
    {
        return derived.Sum() % 2 == 0;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<bool>(solution.DoesValidArrayExist(new int[]{1,1,0}), true),
            ResultTester.CheckResult<bool>(solution.DoesValidArrayExist(new int[]{1,1}), true),
            ResultTester.CheckResult<bool>(solution.DoesValidArrayExist(new int[]{1,0}), false)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Neighboring Bitwise XOR");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}