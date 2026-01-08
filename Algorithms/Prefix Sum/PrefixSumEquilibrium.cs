namespace CompetitiveProgramming.Algorithms.PrefixSumEquilibrium;

public class PrefixSumEquilibrium
{
    // Find if any index exists such that the sum of elements to its right is equal to the sum of elements to its left
    private static bool IsPrefixSumEquilibrium(int[] nums)
    {
        int finalIndex = -1;
        int n = nums.Length;
        int totalSum = 0;
        int leftSum = 0;

        for (int i = 0; i < n; i++)
        {
            totalSum += nums[i];
        }

        for (int i = 0; i < n; i++)
        {
            totalSum = totalSum - nums[i];
            if (leftSum == totalSum)
            {
                finalIndex = i;
                break;
            }
            leftSum += nums[i];
        }

        if (finalIndex != -1) return true;
        else return false;
    }

    // Get Index where there is an equilibrium
    private static int GetPrefixSumEquilibrium(int[] nums)
    {
        int finalIndex = -1;
        int n = nums.Length;
        int totalSum = 0;
        int leftSum = 0;

        for (int i = 0; i < n; i++)
        {
            totalSum += nums[i];
        }

        for (int i = 0; i < n; i++)
        {
            totalSum = totalSum - nums[i];
            if (leftSum == totalSum)
            {
                finalIndex = i;
                break;
            }
            leftSum += nums[i];
        }

        return finalIndex;
    }

    private static bool IsPrefixSumEquilibriumBruteForce(int[] nums)
    {
        int finalIndex = -1;
        int n = nums.Length;

        for (int i = 0; i < n; i++)
        {
            int leftSum = 0, rightSum = 0;
            for (int j = 0; j < i; j++)
            {
                leftSum += nums[j];
            }
            for (int k = i + 1; k < n; k++)
            {
                rightSum += nums[k];
            }
            if (leftSum == rightSum)
            {
                finalIndex = i;
                break;
            }
        }

        if (finalIndex != -1) return true;
        else return false;
    }

    private static int GetPrefixSumEquilibriumBruteForce(int[] nums)
    {
        int finalIndex = -1;
        int n = nums.Length;

        for (int i = 0; i < n; i++)
        {
            int leftSum = 0, rightSum = 0;
            for (int j = 0; j < i; j++)
            {
                leftSum += nums[j];
            }
            for (int k = i + 1; k < n; k++)
            {
                rightSum += nums[k];
            }
            if (leftSum == rightSum)
            {
                finalIndex = i;
                break;
            }
        }

        return finalIndex;
    }
}