// Sum of GCD of Formed Pairs
namespace CompetitiveProgramming.LeetCode.SumofGCDofFormedPairs;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    private int GCD(int a, int b)
    {
        if(a == 0 || b == 0)
            return a | b;
        else if(a == b)
            return a;
        else if(a > b)
            return GCD(a%b, b);
        else
            return GCD(a, b%a);
    }

    public long GcdSum(int[] nums)
    {
        int len = nums.Length;
        if(len == 1)
            return 0;

        List<int> preGCD = new();
        int preMax = 0;
        foreach(int n in nums)
        {
            preMax = Math.Max(preMax, n);
            int curGCD = GCD(preMax, n);
            preGCD.Add(curGCD);
        }

        preGCD.Sort();
        int low = 0, high = len-1;
        long res = 0;
        while(low < high)
        {
           int p1 = preGCD[low++], p2 = preGCD[high--];
           int cur = GCD(p1, p2);
           res += cur;
        }

        return res;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sum of GCD of Formed Pairs");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}