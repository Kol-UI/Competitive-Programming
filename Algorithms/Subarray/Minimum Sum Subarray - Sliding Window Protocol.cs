namespace CompetitiveProgramming.Algorithms;

public class SlidingWindowProtocol
{
    // Example: [2, 3, 1, 2, 4, 3], target 7 -> Min length is 2 ([4, 3])
    // Attention Non negativ numbers
    public static int GetMinSubarrayLength(int[] nums, int targetSum)
    {
        int n = nums.Length;
        int minLength = int.MaxValue;
        int currentSum = 0;
        int start = 0;

        for (int end = 0; end < n; end++)
        {
            currentSum += nums[end];

            while (currentSum >= targetSum)
            {
                int currentLength = (end - start + 1);
                minLength = Math.Min(minLength, currentLength);

                currentSum -= nums[start];
                start++;
            }
        }

        return (minLength == int.MaxValue) ? 0 : minLength;
    }

    // Returns (2, 4, 5) (value, start index, end index)
    public static (int minLen, int start, int end) GetMinSubarrayWithIndices(int[] nums, int target)
    {
        int n = nums.Length;
        int minLen = int.MaxValue;
        int bestStart = -1, bestEnd = -1;

        int currentSum = 0;
        int left = 0;

        for (int right = 0; right < n; right++)
        {
            currentSum += nums[right];

            while (currentSum >= target)
            {
                int currentLen = right - left + 1;
                if (currentLen < minLen)
                {
                    minLen = currentLen;
                    bestStart = left;
                    bestEnd = right;
                }

                currentSum -= nums[left];
                left++;
            }
        }

        return (minLen == int.MaxValue ? 0 : minLen, bestStart, bestEnd);
    }
}