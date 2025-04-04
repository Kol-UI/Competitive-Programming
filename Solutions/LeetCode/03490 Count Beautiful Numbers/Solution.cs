// Count Beautiful Numbers
namespace CompetitiveProgramming.LeetCode.CountBeautifulNumbers;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int BeautifulNumbers(int l, int r)
    {
        int countR = CountUpTo(r);
        int countL = CountUpTo(l - 1);
        return countR - countL;
    }
    
    private int CountUpTo(int n)
    {
        if(n <= 0)
            return 0;
        string s = n.ToString();
        var memo = new Dictionary<(int pos, bool tight, bool started, int sum, long prod), int>();
        return Dp(s, 0, true, false, 0, 1, memo);
    }
    
    private int Dp(string s, int pos, bool tight, bool started, int sum, long prod, 
                   Dictionary<(int pos, bool tight, bool started, int sum, long prod), int> memo)
    {
        if (pos == s.Length)
        {
            if (!started)
                return 0;
            return (prod % sum == 0) ? 1 : 0;
        }
        
        var key = (pos, tight, started, sum, prod);
        if(memo.ContainsKey(key))
            return memo[key];
        
        int total = 0;
        int limit = tight ? s[pos] - '0' : 9;
        for (int d = 0; d <= limit; d++)
        {
            bool nStarted = started;
            int nSum = sum;
            long nProd = prod;
            
            if (!started)
            {
                if(d != 0)
                {
                    nStarted = true;
                    nSum = d;
                    nProd = d;
                }
            }
            else
            {
                nSum = sum + d;
                nProd = (d == 0 ? 0 : prod * d);
            }
            
            bool nTight = tight && (d == limit);
            total += Dp(s, pos + 1, nTight, nStarted, nSum, nProd, memo);
        }
        
        memo[key] = total;
        return total;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Beautiful Numbers");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}