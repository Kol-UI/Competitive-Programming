// Minimum String Length After Balanced Removals
namespace CompetitiveProgramming.LeetCode.MinimumStringLengthAfterBalancedRemovals;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinLengthAfterRemovals(string s)
    {
        var stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (stack.Any() && stack.Peek() != s[i])
                stack.Pop();
            else
                stack.Push(s[i]);
        }

        return stack.Count;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinLengthAfterRemovals("aabbab"), 0),
            ResultTester.CheckResult<int>(solution.MinLengthAfterRemovals("aaaa"), 4),
            ResultTester.CheckResult<int>(solution.MinLengthAfterRemovals("aaabb"), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum String Length After Balanced Removals");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}