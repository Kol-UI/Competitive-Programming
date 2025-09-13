// Count Beautiful Splits in an Array
namespace CompetitiveProgramming.LeetCode.CountBeautifulSplitsinanArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    private readonly int mod = (int)Math.Pow(10, 9) + 7;
    private bool IsPrefix(long[] preHash, int start1, int end1, int start2, int end2, long[] pow)
    {
        int len1 = end1 - start1;
        if (end2-start2 < len1)
            return false;

        long h1 = (preHash[end1] - (preHash[start1] * pow[len1]) % mod + mod) % mod;
        long h2 = (preHash[start2+len1] - (preHash[start2] * pow[len1]) % mod + mod) % mod; 
        return h1 == h2;
    }

    public int BeautifulSplits(int[] nums)
    {
        int len = nums.Length, res = 0;
        if (len < 3)
            return res;
        long baseN = 31;
        long[] preHash = new long[len+1];
        long[] pow = new long[len+1];
        pow[0] = 1;
        for (int i = 0; i < len; i++)
        {
            pow[i + 1] = (pow[i] * baseN) % mod;
            preHash[i+1] = (preHash[i]*baseN + nums[i]) % mod;
        }

        for (int i = 1; i < len - 1; i++)
        {
            for (int j = i + 1; j < len; j++)
            {
                if (IsPrefix(preHash, 0, i, i, j, pow) || IsPrefix(preHash, i, j, j, len, pow))
                    res++;
            }
        }

        return res;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Beautiful Splits in an Array");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}
