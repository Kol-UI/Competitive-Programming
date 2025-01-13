// Minimum Length of String After Operations

namespace CompetitiveProgramming.LeetCode.MinimumLengthofStringAfterOperations;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinimumLength(string s)
    {
        int[] charFrequency = new int[26];
        int totalLength = 0;
        foreach (char c in s)
        {
            charFrequency[c - 'a']++;
        }
        foreach (int frequency in charFrequency)
        {
            if (frequency == 0) continue;
            if (frequency % 2 == 0)
            {
                totalLength += 2;
            }
            else
            {
                totalLength += 1;
            }
        }
        return totalLength;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Length of String After Operations");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}