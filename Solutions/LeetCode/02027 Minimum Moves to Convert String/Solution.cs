// Minimum Moves to Convert String
namespace CompetitiveProgramming.LeetCode.MinimumMovestoConvertString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinimumMoves(string s)
    {
        int cnt = 0, left = 0;
        while(left<s.Length)
        {
            if(s[left] == 'X')
            {
                cnt++;
                left+=3;
            }
            else
            {
                left++;
            }
           
        }
        return cnt;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinimumMoves("XXX"), 1),
            ResultTester.CheckResult<int>(solution.MinimumMoves("XXOX"), 2),
            ResultTester.CheckResult<int>(solution.MinimumMoves("OOOO"), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Moves to Convert String");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}