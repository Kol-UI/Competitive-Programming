namespace CompetitiveProgramming.Algorithms.PrefixSum;

public class PrefixSum
{
    #region LC 1480
    public static int[] GetPrefixSum(int[] nums)
    {
        int size = nums.Length;
        int[] prefix = new int[size];
        prefix[0] = nums[0];

        for (int i = 1; i < size; i++)
        {
            prefix[i] = prefix[i - 1] + nums[i];
        }
        return prefix;
    }
    #endregion
}