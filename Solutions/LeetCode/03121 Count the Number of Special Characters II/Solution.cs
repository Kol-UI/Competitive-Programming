// Count the Number of Special Characters II
namespace CompetitiveProgramming.LeetCode.CounttheNumberofSpecialCharactersII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int NumberOfSpecialChars(string word)
    {
        int[] lastLow = new int[26];
        int[] firstUp = new int[26];
        Array.Fill(lastLow, -1);
        Array.Fill(firstUp, -1);
        for (int i = 0; i < word.Length; i++)
        {
            char c = word[i];
            if (char.IsLower(c))
            {
                lastLow[c - 'a'] = i;
            }
            else
            {
                if (firstUp[c - 'A'] == -1)
                {
                    firstUp[c - 'A'] = i;
                }
            }
        }
        int ans = 0;
        for (int i = 0; i < 26; i++)
        {
            if (lastLow[i] != -1 && firstUp[i] != -1 &&
                lastLow[i] < firstUp[i])
                {
                ans++;
            }
        }
        return ans;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.NumberOfSpecialChars("aaAbcBC"), 3),
            ResultTester.CheckResult<int>(solution.NumberOfSpecialChars("abc"), 0),
            ResultTester.CheckResult<int>(solution.NumberOfSpecialChars("AbBCab"), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count the Number of Special Characters II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}