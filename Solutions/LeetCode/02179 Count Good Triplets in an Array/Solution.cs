// Count Good Triplets in an Array
namespace CompetitiveProgramming.LeetCode.CountGoodTripletsinanArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#nullable disable
public class Solution {
    private int[] ids;
    private int[] dpIds;
    private int PreSum(int idx)
    {
        int sum = 0;
        while (idx > 0)
        { 
            sum += dpIds[idx];
            idx -= (idx & -idx);
        }

        return sum;
    }

    private void Update(int idx, int val)
    {
        while (idx <dpIds.Length)
        {
            dpIds[idx] += val;
            idx += (idx & -idx);
        }
    }

    public long GoodTriplets(int[] nums1, int[] nums2) {
        long res = 0;
        int len = nums1.Length;
        ids = new int[len];
        dpIds = new int[len+1];
        for (int i = 0; i < len; i++)
        {
            ids[nums2[i]] = i;
        }

        for (int i = 0; i < len - 1; i++)
        {
            int mid = ids[nums1[i]], smaller = PreSum(mid+1), larger = len-mid-(i-smaller) - 1;
            res += (long)smaller * larger;
            Update(mid+1, 1);
        }

        return res;
    }
}
#nullable enable
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Good Triplets in an Array");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}