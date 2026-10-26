// Reverse Pairs
namespace CompetitiveProgramming.LeetCode.ReversePairs;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int ReversePairs(int[] nums)
    {
        return MergeSortAndCount(nums, 0, nums.Length - 1);
    }

    private int MergeSortAndCount(int[] nums, int start, int end)
    {
        if (start < end)
        {
            int mid = (start + end) / 2;
            int count = MergeSortAndCount(nums, start, mid) + MergeSortAndCount(nums, mid + 1, end);
            int j = mid + 1;
            for (int i = start; i <= mid; i++)
            {
                while (j <= end && nums[i] > nums[j] * 2L)
                    j++;
                count += j - (mid + 1);
            }
            Merge(nums, start, mid, end);
            return count;
        }
        else
            return 0;
    }

    private void Merge(int[] nums, int start, int mid, int end)
    {
        int n1 = mid - start + 1;
        int n2 = end - mid;
        var L = new int[n1];
        var R = new int[n2];

        int i = 0, j = 0;
        for (i = 0; i < n1; i++)
            L[i] = nums[start + i];
        for (j = 0; j < n2; j++)
            R[j] = nums[mid + 1 + j];
        i = 0; j = 0;
        for (int k = start; k <= end; k++)
        {
            if (j >= n2 || (i < n1 && L[i] <= R[j]))
                nums[k] = L[i++];
            else
                nums[k] = R[j++];
        }
    }
   
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.ReversePairs([1,3,2,3,1]), 2),
            ResultTester.CheckResult<int>(solution.ReversePairs([2,4,3,5,1]), 3)
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Reverse Pairs");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}