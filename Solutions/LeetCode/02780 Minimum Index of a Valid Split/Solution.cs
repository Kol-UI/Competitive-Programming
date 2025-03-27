// Minimum Index of a Valid Split
namespace CompetitiveProgramming.LeetCode.MinimumIndexofaValidSplit;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinimumIndex(IList<int> nums)
    {
        Dictionary<int,int> cache = new();
        for(int i=0;i<nums.Count;i++)
        {
            if(cache.ContainsKey(nums[i]))
                cache[nums[i]]++;
            else cache.Add(nums[i], 1);
        }
        
        int dominateNum = 0, mxFreq = 0;
        foreach(var item in cache)
        {
            mxFreq = Math.Max(mxFreq, item.Value);
            if(mxFreq == item.Value)
                dominateNum = item.Key;
        }

        int leftFreq = 0, rightFreq = cache[dominateNum];
        for(int i=0;i<nums.Count ;i++)
        {
            if(nums[i] == dominateNum)
            {
                int sizeLeft = i+1;
                int sizeRight = nums.Count - (i+1);

                leftFreq++;
                rightFreq--;
                sizeLeft/=2;
                sizeRight/=2;
           
                if(leftFreq > sizeLeft && rightFreq > sizeRight)
                    return i;
            }
        }

        return -1;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Index of a Valid Split");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}