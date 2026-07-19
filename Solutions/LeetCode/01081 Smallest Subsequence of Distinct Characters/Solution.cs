// Smallest Subsequence of Distinct Characters
namespace CompetitiveProgramming.LeetCode.SmallestSubsequenceofDistinctCharacters;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution 
{
    public string SmallestSubsequence(string s) 
    {
        var stack = new Stack<char>();
        var set = new HashSet<char>();
        var lastIndex = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++)
            lastIndex[s[i]] = i;

        for (var i = 0; i < s.Length; i++)
        {
            if (set.Contains(s[i])) continue;

            while (stack.TryPeek(out var topLetter) && topLetter > s[i] && lastIndex[topLetter] > i)
            {
                stack.Pop();
                set.Remove(topLetter);
            }

            stack.Push(s[i]);
            set.Add(s[i]);
        }

        var arr = stack.ToArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.SmallestSubsequence("bcabc"), "abc"),
            ResultTester.CheckResult<string>(solution.SmallestSubsequence("cbacdcbc"), "acdb"),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Smallest Subsequence of Distinct Characters");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}