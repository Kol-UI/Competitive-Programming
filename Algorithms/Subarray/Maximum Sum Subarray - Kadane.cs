namespace CompetitiveProgramming.Algorithms;

public class Kadane
{
    // Example: [-2, 1, -3, 4, -1, 2, 1] -> Max sum is 6 ([4, -1, 2, 1])
    public static int GetMaxSubarraySum(int[] nums)
    {
        int currentMax = nums[0];
        int globalMax = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            currentMax = Math.Max(nums[i], currentMax + nums[i]);
            if (currentMax > globalMax)
            {
                globalMax = currentMax;
            }
        }

        return globalMax;
    }

    // Returns (6, 3, 6) (value, start index, end index)
    public static (int maxSum, int start, int end) GetKadaneWithIndices(int[] nums)
    {
        int globalMax = nums[0];
        int currentMax = nums[0];
        int start = 0;
        int end = 0;
        int tempStart = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > currentMax + nums[i])
            {
                currentMax = nums[i];
                tempStart = i;
            }
            else
            {
                currentMax += nums[i];
            }

            if (currentMax > globalMax)
            {
                globalMax = currentMax;
                start = tempStart;
                end = i;
            }
        }
        return (globalMax, start, end);
    }
}