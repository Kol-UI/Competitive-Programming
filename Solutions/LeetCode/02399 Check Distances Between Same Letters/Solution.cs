// Check Distances Between Same Letters
namespace CompetitiveProgramming.LeetCode.CheckDistancesBetweenSameLetters;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public bool CheckDistances(string s, int[] distance)
    {
        var dict = new Dictionary<int, int>();
        for(var i = 0; i < s.Length; i++)
            if(!dict.ContainsKey(s[i] - 97))
                dict[s[i] - 97] = i;
            else
                dict[s[i] - 97] = Math.Abs(dict[s[i] - 97] - i + 1);
        for(var i = 0; i < distance.Length; i++)
            if(dict.ContainsKey(i) && dict[i] != distance[i])
                return false;
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
            ResultTester.CheckResult<bool>(solution.CheckDistances("abaccb", [1,3,0,5,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0]), true),
            ResultTester.CheckResult<bool>(solution.CheckDistances("aa", [1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0]), false),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Check Distances Between Same Letters");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}