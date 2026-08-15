// Longest Subsequence With Non-Zero Bitwise XOR
namespace CompetitiveProgramming.LeetCode.LongestSubsequenceWithNonZeroBitwiseXOR;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int LongestSubsequence(int[] nums)
    {
        int xor = 0;
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
                xor = xor ^ nums[i];
            else 
                count++;
        }
        if (count == nums.Length)
            return 0;
        return xor == 0 ? nums.Length - 1 : nums.Length;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.LongestSubsequence([1,2,3]), 2),
            ResultTester.CheckResult<int>(solution.LongestSubsequence([2,3,4]), 3)
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Longest Subsequence With Non-Zero Bitwise XOR");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}