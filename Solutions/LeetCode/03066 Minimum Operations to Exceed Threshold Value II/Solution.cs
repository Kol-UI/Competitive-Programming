// Minimum Operations to Exceed Threshold Value II

namespace CompetitiveProgramming.LeetCode.MinimumOperationstoExceedThresholdValueII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinOperations(int[] nums, int k)
    {
        int result = 0;
        List<long> newNums = new();
        
        Array.Sort(nums, (a, b) => b.CompareTo(a));

        int i = nums.Length - 1;
        int j = 0;

        while (true)
        {
            long a = GetNextValue(ref i, ref j, nums, newNums);
            if (a >= k) return result;

            long b = GetNextValue(ref i, ref j, nums, newNums);
            newNums.Add(a * 2 + b);
            result++;
        }
    }

    private long GetNextValue(ref int i, ref int j, int[] nums, List<long> newNums)
    {
        if (j < newNums.Count && (i < 0 || newNums[j] < nums[i]))
            return newNums[j++];
        return nums[i--];
    }
}


public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Operations to Exceed Threshold Value II");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}