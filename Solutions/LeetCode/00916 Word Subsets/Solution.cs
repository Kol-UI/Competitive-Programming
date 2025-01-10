// Word Subsets

namespace CompetitiveProgramming.LeetCode.WordSubsets;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public IList<string> WordSubsets(string[] words1, string[] words2)
    {
        var result = new List<string>();
        
        int[] maxCount = new int[26];
        foreach (string word in words2) 
        {
            int[] count = Count(word);
            for (int i = 0; i < 26; i++)
            {
                maxCount[i] = Math.Max(maxCount[i], count[i]);
            }
        }

        foreach (string word in words1)
        {
            int[] count = Count(word);
            bool valid = true;
            for (int i = 0; i < 26; i++)
            {
                if (count[i] < maxCount[i])
                {
                    valid = false;
                    break;
                }
            }
            if (valid) result.Add(word);
        }
        
        return result;
    }

    private int[] Count(string word)
    {
        int[] count = new int[26];
        foreach (char c in word)
        {
            count[c - 'a']++;
        }
        return count;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Word Subsets");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}