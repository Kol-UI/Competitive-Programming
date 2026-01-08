namespace CompetitiveProgramming.Algorithms;

public class KadaneModified
{
    // Example: [1, 10, -5, 10], k = 2 -> Max sum is 11 ([1, 10]) because [10, -5, 10] is length 3
    public static int GetMaxSubarraySumWithLimit(int[] nums, int maxLen)
    {
        int globalMax = int.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            int currentWindowSum = 0;

            for (int length = 1; length <= maxLen; length++)
            {
                int endIdx = i + length - 1;
                if (endIdx < nums.Length)
                {
                    currentWindowSum += nums[endIdx];
                    globalMax = Math.Max(globalMax, currentWindowSum);
                }
            }
        }

        return globalMax;
    }

    // Returns (11, 0, 1) (value, start index, end index)
    public static (int maxSum, int start, int end) GetMaxSubarraySumIndicesWithLimit(int[] nums, int k)
    {
        int globalMax = int.MinValue;
        int start = 0;
        int end = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            int currentWindowSum = 0;
            for (int len = 1; len <= k && (i + len - 1) < nums.Length; len++)
            {
                int endIdx = i + len - 1;
                currentWindowSum += nums[endIdx];

                if (currentWindowSum > globalMax)
                {
                    globalMax = currentWindowSum;
                    start = i;
                    end = endIdx;
                }
            }
        }
        return (globalMax, start, end);
    }
}