// Number of Substrings Containing All Three Characters
namespace CompetitiveProgramming.LeetCode.NumberofSubstringsContainingAllThreeCharacters;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int NumberOfSubstrings(string s)
    {
        int[] count = new int[3]; 
        int left = 0, result = 0;

        for (int right = 0; right < s.Length; right++)
        {
            count[s[right] - 'a']++; 
            while (count[0] > 0 && count[1] > 0 && count[2] > 0)
            {
                result += s.Length - right; 
                count[s[left] - 'a']--; 
                left++;
            }
        }

        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Number of Substrings Containing All Three Characters");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}