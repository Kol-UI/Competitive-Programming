// Count the Number of Substrings With Dominant Ones
namespace CompetitiveProgramming.LeetCode.CounttheNumberofSubstringsWithDominantOnes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int NumberOfSubstrings(string s)
    {
        int n = 0;
        foreach(char c in s)
         if(c == '1') n++;
        int total = 0,ns = (int)Math.Sqrt(n),nzt = s.Length-n;
        if((ns + 1) * (ns + 1) <= n) ns++;
        for(int l = 0; l < s.Length; l++)
        {
            int nz = 0, no = 0;
            for(int r = l;(r < s.Length) && (nz <= ns); r++)
            {
                if(s[r]=='1')no++;else nz++;
                if(no>=nzt*nzt){ total+= s.Length-r;break;}
                if(no>=nz*nz)total++;

            }
            if(s[l]=='1')n--;else nzt--;
            if(ns*ns>n)ns--;
        }
        return total;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count the Number of Substrings With Dominant Ones");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}