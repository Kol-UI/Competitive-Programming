// Find the XOR of Numbers Which Appear Twice
namespace CompetitiveProgramming.LeetCode.FindtheXORofNumbersWhichAppearTwice;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int DuplicateNumbersXOR(int[] nums)
    {
        var set = new HashSet<int>();
        var result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (!set.Contains(nums[i])) set.Add(nums[i]);
            else result ^= nums[i];
        }
        return result;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.DuplicateNumbersXOR([1,2,1,3]), 1),
            ResultTester.CheckResult<int>(solution.DuplicateNumbersXOR([1,2,3]), 0),
            ResultTester.CheckResult<int>(solution.DuplicateNumbersXOR([1,2,2,1]), 3),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find the XOR of Numbers Which Appear Twice");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}