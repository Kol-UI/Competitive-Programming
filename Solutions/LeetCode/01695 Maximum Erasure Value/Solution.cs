// Maximum Erasure Value
namespace CompetitiveProgramming.LeetCode.MaximumErasureValue;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaximumUniqueSubarray(int[] nums)
    {
        int start = 0;
        int end = 0;
        int maxScore = 0;
        int score = 0;
        var hashSet = new HashSet<int>();
        
        while(end < nums.Length)
        {
            if(hashSet.Contains(nums[end]))
            {
                score = score - nums[start];
                hashSet.Remove(nums[start++]);
            }
            else
            {
                score += nums[end];
                hashSet.Add(nums[end++]);
            }
            
            maxScore = Math.Max(maxScore, score);
        }
        
        return maxScore;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Erasure Value");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}