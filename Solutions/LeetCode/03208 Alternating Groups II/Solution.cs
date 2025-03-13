// Alternating Groups II
namespace CompetitiveProgramming.LeetCode.AlternatingGroupsII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int NumberOfAlternatingGroups(int[] colors, int k)
    {
        int left = 0, result = 0, n = colors.Length;
        for(int right = 0; right < (n + k) - 1; right++)
        {
            if(colors[(right % n)] == colors[(right + 1) % n])
            {
                left = right;
            }
            if(right - left + 1 == k)
            {
                result++;
                left++;
            }
        }
        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.NumberOfAlternatingGroups(new int[]{0,1,0,1,0}, 3), 3),
            ResultTester.CheckResult<int>(solution.NumberOfAlternatingGroups(new int[]{0,1,0,0,1,0,1}, 6), 2),
            ResultTester.CheckResult<int>(solution.NumberOfAlternatingGroups(new int[]{1,1,0,1}, 4), 0)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Alternating Groups II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
} 