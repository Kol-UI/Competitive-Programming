// Maximum Subarray Sum With Length Divisible by K
namespace CompetitiveProgramming.LeetCode.MaximumSubarraySumWithLengthDivisiblebyK;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long MaxSubarraySum(int[] nums, int k) 
    {
        int n=nums.Length;
        long[] ps=new long[n];
        Dictionary<int,long> map=new Dictionary<int,long>();
        
        ps[0]=nums[0];
        
        for(int i=1;i<n;i++)
        {
            ps[i]=ps[i-1]+nums[i];
        }
        
        long ans=long.MinValue;
        
        for(int i=0;i<n;i++)
        {
            int len=i+1;
            int rem=(len%k);
            
            if(rem==0)
            {
                ans=Math.Max(ans,ps[i]);
            }
            
            if(map.ContainsKey(rem))
            {
                long sum=ps[i]-map[rem];
                ans=Math.Max(ans,sum);
            }

            if(!map.ContainsKey(rem))
            {
                map.Add(rem,ps[i]);
            }
            else
            {
                map[rem]=Math.Min(map[rem],ps[i]);
            }     
        }
        return ans;   
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Subarray Sum With Length Divisible by K");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}