// Number of Ways to Split Array

namespace CompetitiveProgramming.LeetCode.NumberofWaystoSplitArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int WaysToSplitArray(int[] nums)
    {
        int n = nums.Length;
        long totalSum = 0;

        foreach (int num in nums)
        {
            totalSum += num;
        }

        long leftSum = 0;
        int validSplits = 0;

        for (int i = 0; i < n - 1; i++)
        {
            leftSum += nums[i];
            long rightSum = totalSum - leftSum;

            if (leftSum >= rightSum)
            {
                validSplits++;
            }
        }

        return validSplits;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();

        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.WaysToSplitArray(new int[]{10,4,-8,7}), 2),
            ResultTester.CheckResult<int>(solution.WaysToSplitArray(new int[]{2,3,1,0}), 2),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Number of Ways to Split Array");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}