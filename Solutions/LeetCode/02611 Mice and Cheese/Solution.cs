// Mice and Cheese
namespace CompetitiveProgramming.LeetCode.MiceandCheese;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MiceAndCheese(int[] reward1, int[] reward2, int k) => reward2.Sum() + reward1.Select((reward, i) => reward - reward2[i]).OrderByDescending(d => d).Take(k).Sum();
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MiceAndCheese([1,1,3,4], [4,4,1,1], 2), 15),
            ResultTester.CheckResult<int>(solution.MiceAndCheese([1,1], [1,1], 2), 2),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Mice and Cheese");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}