// Merge Close Characters
namespace CompetitiveProgramming.LeetCode.MergeCloseCharacters;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public string MergeCharacters(string s, int k)
    {
        int[] last = new int[26];
        Array.Fill(last, -(k + 10));
        List<char> result = new();
        for (int i = 0; i < s.Length; i++)
        {
            var value = s[i] - 'a';
            if (result.Count - last[value] > k)
            {
                last[value] = result.Count;
                result.Add(s[i]);
            }
        }
        return new string(result.ToArray());
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<string>(solution.MergeCharacters("abca", 3), "abc"),
            ResultTester.CheckResult<string>(solution.MergeCharacters("aabca", 2), "abca"),
            ResultTester.CheckResult<string>(solution.MergeCharacters("yybyzybz", 2), "ybzybz"),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Merge Close Characters");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}