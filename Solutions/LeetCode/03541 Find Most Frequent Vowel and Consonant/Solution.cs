// Find Most Frequent Vowel and Consonant
namespace CompetitiveProgramming.LeetCode.FindMostFrequentVowelandConsonant;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxFreqSum(string s)
    {
        int[] vo = new int[26];
        int[] con = new int[26];
        HashSet<char> vowels = new() {'a','e','i','o','u'};

        foreach(char ch in s)
        {
            if(vowels.Contains(ch))
            {
                vo[ch - 'a']++;
            }
            else
            {
                con[ch - 'a']++;
            }
        }

        return vo.Max() + con.Max();
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find Most Frequent Vowel and Consonant");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}