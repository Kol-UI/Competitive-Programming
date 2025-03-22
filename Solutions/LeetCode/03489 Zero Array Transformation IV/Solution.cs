// Zero Array Transformation IV
namespace CompetitiveProgramming.LeetCode.ZeroArrayTransformationIV;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinZeroArray(int[] nums, int[][] queries)
    {
        bool allZero = true;
        for(int i = 0;i<nums.Length;i++) if(nums[i]!=0) { allZero=false;break; }
        if(allZero) return 0;
        if(!CanZero(nums, queries.Length, queries)) return -1;
        int left=1,right=queries.Length,ans=-1;
        while(left<=right)
        {
            int mid=(left+right)/2;
            if(CanZero(nums, mid, queries)) { ans=mid; right=mid-1; }
            else left=mid+1;
        }
        return ans;
    }

    bool CanZero(int[] nums, int k, int[][] q)
    {
        for(int i=0;i<nums.Length;i++)
        {
            var vals=new List<int>();
            for(int j=0;j<k;j++)
            {
                if(i>=q[j][0] && i<=q[j][1]) vals.Add(q[j][2]);
            }
            if(!CanForm(nums[i], vals)) return false;
        }
        return true;
    }

    bool CanForm(int target, List<int> vals)
    {
        if(target==0) return true;
        var dp=new bool[target+1];
        dp[0]=true;
        foreach(var v in vals)
        {
            for(int s=target;s>=v;s--)
            {
                if(dp[s-v]) dp[s]=true;
            }
        }
        return dp[target];
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Zero Array Transformation IV");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}