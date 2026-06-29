// Destroying Asteroids
namespace CompetitiveProgramming.LeetCode.DestroyingAsteroids;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool AsteroidsDestroyed(int mass, int[] asteroids)
    {
        Array.Sort(asteroids);
        if(asteroids[0] > mass)
        {
            return false;
        }

        long current = asteroids[0] + mass;
        for(var i = 1; i < asteroids.Length; i++)
        {
            if(asteroids[i] > current)
            {
                return false;
            }
            current += asteroids[i];
        }
        return true;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<bool>(solution.AsteroidsDestroyed(10, [3,9,19,5,21]), true),
            ResultTester.CheckResult<bool>(solution.AsteroidsDestroyed(5, [4,9,23,4]), false),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Destroying Asteroids");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}