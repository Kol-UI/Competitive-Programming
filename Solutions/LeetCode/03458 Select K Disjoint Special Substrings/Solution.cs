// Select K Disjoint Special Substrings
namespace CompetitiveProgramming.LeetCode.SelectKDisjointSpecialSubstrings;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    Dictionary<char, int>? firstIndexes;
    Dictionary<char, int>? lastIndexes;
    HashSet<char>? allowedChars;

    public int EndOfGroupStartedWith(char c, string s)
    {
        int i = firstIndexes![c];
        int last = lastIndexes![c]; 
       
        while (++i < last)
        {
            if ((firstIndexes[s[i]] < firstIndexes[c]))
                return Int32.MaxValue;
            
            if (s[i] != s[i - 1])
                last = Math.Max(last, lastIndexes[s[i]]);       
        }
        
        return last;       
    }

    public bool MaxSubstringLength(string s, int k) 
    {                            
        int kk = k;
        allowedChars = s.Distinct().ToHashSet();
        firstIndexes = allowedChars.ToDictionary(x => x, x => s.IndexOf(x)); 
        lastIndexes = allowedChars.ToDictionary(x => x, x => s.LastIndexOf(x));      
        while (k-- > 0)
        {
            int min = Int32.MaxValue;
            foreach (char c in allowedChars)            
                min = Math.Min(min, EndOfGroupStartedWith(c, s));

            if (kk == 1 && min == s.Length - 1)
                return false;

            if (min == Int32.MaxValue)
                return false;

            allowedChars.ExceptWith(s.Take(min + 1).Distinct());
        }
  
        return true;    
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Select K Disjoint Special Substrings");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}