// Maximum Length Substring With Two Occurrences
namespace CompetitiveProgramming.LeetCode.MaximumLengthSubstringWithTwoOccurrences;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaximumLengthSubstring(string s) 
    {
        var charSet = new Dictionary<char, int>();
        var maxLength = 0;
        var k = 2;
        var left = 0;
        var right = 0;
        for(right = 0; right < s.Length; right++)
        {
            var currChar = s[right];
            if(!charSet.ContainsKey(currChar))
            {
            charSet.Add(currChar, 1);
            }
            else 
            {
            charSet[currChar] =  charSet[currChar] + 1;
            }

            if(charSet[currChar] > k)
            {
            maxLength = Math.Max(maxLength, right - left);
            while(charSet[currChar] > k)
            {
                var subArrayChar = s[left];
                charSet[subArrayChar] = charSet[subArrayChar] - 1;
                if(charSet[subArrayChar] == 0)
                {
                    charSet.Remove(subArrayChar);
                }

                left++;
            }

            }
        }
        
        maxLength = Math.Max(maxLength , right - left);
        return maxLength;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Length Substring With Two Occurrences");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}