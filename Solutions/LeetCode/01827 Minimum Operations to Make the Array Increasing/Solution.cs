// Minimum Operations to Make the Array Increasing
namespace CompetitiveProgramming.LeetCode.MinimumOperationstoMaketheArrayIncreasing;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinOperations(int[] nums)
    {
        if(nums.Length == 1) return 0;
        int ans = 0;
        for(int i = 0;i < nums.Length - 1;i++)
        {  
            if(nums[i+1] <= nums[i])
            {
                ans += nums[i] - nums[i+1] + 1;
                nums[i+1] = nums[i] + 1;
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
        StyleHelper.Title("Minimum Operations to Make the Array Increasing");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}