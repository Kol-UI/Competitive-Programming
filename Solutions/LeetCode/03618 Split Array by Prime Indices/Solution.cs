// Split Array by Prime Indices
namespace CompetitiveProgramming.LeetCode.SplitArraybyPrimeIndices;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long SplitArray(int[] nums)
    {
        int len = nums.Length;
        int sqLen = (int)Math.Sqrt(len);
        bool[] isPrime = Enumerable.Repeat(true, len).ToArray();
        isPrime[0] = false;
        if(len > 1)
            isPrime[1] = false;
            
        for(int i = 2; i <= sqLen; i++)
        {
            if(isPrime[i])
            {
                int j = i+i;
                while(j < len)
                {
                    isPrime[j] = false;
                    j += i;
                }
            }
        }

        long sum = 0;
        for(int i = 0; i < len; i++)
        {
            int cur = nums[i];
            if(isPrime[i])
                cur = -cur;

            sum += cur;
        }

        return Math.Abs(sum);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Split Array by Prime Indices");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}