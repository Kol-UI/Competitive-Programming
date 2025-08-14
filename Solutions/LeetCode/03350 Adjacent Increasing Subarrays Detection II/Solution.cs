// Adjacent Increasing Subarrays Detection II
namespace CompetitiveProgramming.LeetCode.AdjacentIncreasingSubarraysDetectionII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxIncreasingSubarrays(IList<int> nums)
    {
        int len = nums.Count, res = 1;
        int cnt = 1, preLen = -1;
        if(len < 2)
            return 0;

        for(int i = 1; i < len; i++)
        {
           if(nums[i] <= nums[i-1])
           {
                res = Math.Max(res, cnt/2);
                if(preLen > 0)
                {
                    int validTwo = Math.Min(preLen, cnt);
                    res = Math.Max(res, validTwo);
                }
              
                preLen = cnt;
                cnt = 1;
           }
           else
                cnt++;

            if(i == len-1)
            {
                res = Math.Max(res, cnt/2);
                if(preLen > 0)
                {
                    int validTwo = Math.Min(preLen, cnt);
                    res = Math.Max(res, validTwo);
                }
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
        StyleHelper.Title("Adjacent Increasing Subarrays Detection II");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}