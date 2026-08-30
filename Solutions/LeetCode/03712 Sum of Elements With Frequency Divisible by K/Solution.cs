// Sum of Elements With Frequency Divisible by K
namespace CompetitiveProgramming.LeetCode.SumofElementsWithFrequencyDivisiblebyK;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int SumDivisibleByK(int[] nums, int k)
    {
        Dictionary<int,int> freq = new Dictionary<int,int>();
        int sum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(!freq.ContainsKey(nums[i]))
            {
                freq[nums[i]] = 1;
            }
            else
            {
                freq[nums[i]]++;
            }
        }
        foreach(var f in freq.Keys)
        {
            if(freq[f] % k == 0)
            {
                sum += f * freq[f];
            }
        }
        return sum;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.SumDivisibleByK([1,2,2,3,3,3,3,4], 2), 16),
            ResultTester.CheckResult<int>(solution.SumDivisibleByK([1,2,3,4,5], 2), 0),
            ResultTester.CheckResult<int>(solution.SumDivisibleByK([4,4,4,1,2,3], 3), 12),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sum of Elements With Frequency Divisible by K");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}