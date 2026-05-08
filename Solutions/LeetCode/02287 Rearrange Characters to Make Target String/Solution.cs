// Rearrange Characters to Make Target String
namespace CompetitiveProgramming.LeetCode.RearrangeCharacterstoMakeTargetString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int RearrangeCharacters(string s, string target)
    {
        Span<byte> freqS = stackalloc byte[32];
        Span<byte> freqTarget = stackalloc byte[32];
        foreach (char c in s)
            freqS[c & 31]++;
        foreach (char c in target)
            freqTarget[c & 31]++;
        int copies = int.MaxValue;
        for (int i = 1; i <= 26; i++)
        {
            if (freqTarget[i] > 0)
                copies = int.Min(copies, freqS[i] / freqTarget[i]);
        }
        return copies;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.RearrangeCharacters("ilovecodingonleetcode", "code"), 2),
            ResultTester.CheckResult<int>(solution.RearrangeCharacters("abcba", "abc"), 1),
            ResultTester.CheckResult<int>(solution.RearrangeCharacters("abbaccaddaeea", "aaaaa"), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Rearrange Characters to Make Target String");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}