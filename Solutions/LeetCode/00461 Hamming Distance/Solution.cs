// Hamming Distance
namespace CompetitiveProgramming.LeetCode.HammingDistance;

using System.Numerics;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int HammingDistance(int x, int y) => BitOperations.PopCount((uint)x ^ (uint)y);
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.HammingDistance(1, 4), 2),
            ResultTester.CheckResult<int>(solution.HammingDistance(3, 1), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Hamming Distance");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}