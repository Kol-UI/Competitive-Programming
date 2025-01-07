namespace CompetitiveProgramming.Algorithms.PrefixSum;

public class PrefixSum
{
    private static int[] GetPrefixSum(int[] nums)
    {
        int n = nums.Length;
        int[] result = new int[n];
        result[0] = nums[0];

        for (int i = 1; i < n; i++)
        {
            result[i] = result[i - 1] + nums[i];
        }

        return result;
    }
}