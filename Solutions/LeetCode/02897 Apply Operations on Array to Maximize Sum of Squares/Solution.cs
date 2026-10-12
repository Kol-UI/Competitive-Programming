// Apply Operations on Array to Maximize Sum of Squares
namespace CompetitiveProgramming.LeetCode.ApplyOperationsonArraytoMaximizeSumofSquares;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxSum(IList<int> nums, int k)
    {
        var bits = CountBits(nums);
        var result = 0L;
        for(int i = 0; i < k; i++)
        {
            var n = GetN(bits);
            result += n * n;
            result %= 1_000_000_007;
        }
        return (int)result;
    }
    private long GetN(List<int> bits)
    {
        var result = 0L;
        var mult = 1;
        for (int i = 0; i < bits.Count; i++)
        {
            if (bits[i] > 0)
            {
                result += mult;
                bits[i]--;
            }
            mult *= 2;
        }
        return result;
    }
    private List<int> CountBits(IList<int> nums)
    {
        var result = new List<int>();
        for (int i = 0; i < nums.Count; i++)
        {
            var bits = GetBits(nums[i]);
            for (int j = 0; j < bits.Count; j++)
            {
                if (j < result.Count)
                {
                    result[j] += bits[j];
                }
                else
                {
                    result.Add(bits[j]);
                }
            }
        }
        return result;
    }
    private List<int> GetBits(int num)
    {
        var result = new List<int>();
        while (num > 0)
        {
            result.Add(num % 2);
            num /= 2;
        }
        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MaxSum([2,6,5,8], 2), 261),
            ResultTester.CheckResult<int>(solution.MaxSum([4,5,4,7], 3), 90)
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Apply Operations on Array to Maximize Sum of Squares");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}