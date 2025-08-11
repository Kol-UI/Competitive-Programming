// Find Maximum Number of Non Intersecting Substrings
namespace CompetitiveProgramming.LeetCode.FindMaximumNumberofNonIntersectingSubstrings;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxSubstrings(string word)
    {
        int n = word.Length;
        int count = 0;
        bool[] chars = new bool[26];
        
        for (int i = 3; i < n; i++)
        {
            int pc = word[i - 3] - 'a';
            chars[pc] = true;

            int c = word[i] - 'a';

            if (chars[c])
            {
                chars = new bool[26];
                i += 3;
                count++;
            }
        }

        return count;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find Maximum Number of Non Intersecting Substrings");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}