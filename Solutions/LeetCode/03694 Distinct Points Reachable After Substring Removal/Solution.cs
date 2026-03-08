// Distinct Points Reachable After Substring Removal
namespace CompetitiveProgramming.LeetCode.DistinctPointsReachableAfterSubstringRemoval;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int DistinctPoints(string s, int k)
    {
        var endDestination = new long[2];
        var seen = new HashSet<string>();
        var uniqueDestinations = 0;
        for (int i = 0; i < k; i++)
        {
            updateWindow(s[i], endDestination, false);
        }
        seen.Add($"{endDestination[0]},{endDestination[1]}");
        uniqueDestinations++;

        for (int i = k; i < s.Length; i++)
        {
            updateWindow(s[i], endDestination, true);
            updateWindow(s[i - k], endDestination, false);
            var key = $"{endDestination[0]},{endDestination[1]}";
            if (!seen.Contains(key))
            {
                uniqueDestinations++;
                seen.Add(key);
            }
        }

        return uniqueDestinations;
    }

    private void updateWindow(char c, long[] window, bool Add)
    {
        switch (c)
        {
            case 'U':
                window[1] += Add ? 1 : -1;
                break;
            case 'L':
                window[0] += Add ? -1 : 1;
                break;
            case 'D':
                window[1] += Add ? -1 : 1;
                break;
            case 'R':
                window[0] += Add ? 1 : -1;
                break;
        }
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.DistinctPoints("LUL", 1), 2),
            ResultTester.CheckResult<int>(solution.DistinctPoints("UDLR", 4), 1),
            ResultTester.CheckResult<int>(solution.DistinctPoints("UU", 1), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Distinct Points Reachable After Substring Removal");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}