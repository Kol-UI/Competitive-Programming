// Maximum Frequency of an Element After Performing Operations I
namespace CompetitiveProgramming.LeetCode.MaximumFrequencyofanElementAfterPerformingOperationsI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxFrequency(int[] nums, int k, int numOperations)
    {
        var n = nums.Length;
        if (n == 1)
            return 1;
        
        Array.Sort(nums);
        
        var counts = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (!counts.ContainsKey(num))
                counts[num] = 0;

            counts[num]++;
        }

        var left = 0;
        var right = 1;
        var maxFrequency = 1;

        for (int mid = 1; mid < n; mid++)
        {
            while (nums[mid] - nums[left] > k)
                left++;

            while (right+1 < n && nums[right+1] - nums[mid] <= k)
                right++;

            var midCount = counts[nums[mid]];
            var windowSize = right - left + 1 - midCount;
            var operatedCount = Math.Min(windowSize, numOperations);
            maxFrequency = Math.Max(maxFrequency, operatedCount + midCount);
        }

        left = 0;
        for (right = maxFrequency-1; right < n; right++)
        {
            var mid = (nums[right] + nums[left]) / 2;

            while (mid - nums[left] > k || nums[right] - mid > k)
            {
                left++;
                mid = (nums[right] + nums[left]) / 2;
            }

            var windowSize = right - left + 1;
            var operatedCount = Math.Min(windowSize, numOperations);
            maxFrequency = Math.Max(maxFrequency, operatedCount);
        }
    
        return maxFrequency;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Frequency of an Element After Performing Operations I");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}