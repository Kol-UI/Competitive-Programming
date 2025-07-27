// Count Hills and Valleys in an Array
namespace CompetitiveProgramming.LeetCode.CountHillsandValleysinanArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution 
{
    public int CountHillValley(int[] nums) 
    {
        if (nums.Length < 3) return 0;
        int count = 0;

        for (int i = 1; i < nums.Length - 1; i++) 
        {
            if (nums[i] == nums[i - 1]) continue;
            int left = i - 1;
            int right = i + 1;
            while (left >= 0 && nums[left] == nums[i]) 
            {
                left--;
            }
            while (right < nums.Length && nums[right] == nums[i]) 
            {
                right++;
            }
            left = left >= 0 ? nums[left] : nums[i];
            right = right < nums.Length ? nums[right] : nums[i];

            if ((nums[i] > left && nums[i] > right) || (nums[i] < left && nums[i] < right)) {
                count++;
            }

        }
        return count;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Hills and Valleys in an Array");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}