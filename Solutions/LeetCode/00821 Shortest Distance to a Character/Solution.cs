// Shortest Distance to a Character
namespace CompetitiveProgramming.LeetCode.ShortestDistancetoaCharacter;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] ShortestToChar(string s, char c)
    {
        int n = s.Length;
        int[] result = new int[n];
        int prev = int.MinValue / 2;

        for (int i = 0; i < n; i++)
        {
            if (s[i] == c) prev = i;
            result[i] = i - prev;
        }

        prev = int.MaxValue / 2;

        for (int i = n - 1; i >= 0; i--)
        {
            if (s[i] == c) prev = i;
            result[i] = Math.Min(result[i], prev - i);
        }

        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int[]>(solution.ShortestToChar("loveleetcode", 'e'), [3,2,1,0,1,0,0,1,2,2,1,0]),
            ResultTester.CheckResult<int[]>(solution.ShortestToChar("aaab", 'b'), [3,2,1,0])
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Shortest Distance to a Character");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}