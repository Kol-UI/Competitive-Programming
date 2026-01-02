// N-Repeated Element in Size 2N Array
namespace CompetitiveProgramming.LeetCode.NRepeatedElementinSizeTwoNArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int RepeatedNTimes(int[] nums)
    {
        var set = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (set.Contains(nums[i])) return nums[i];
            set.Add(nums[i]);
        }
        return -1;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.RepeatedNTimes([1,2,3,3]), 3),
            ResultTester.CheckResult<int>(solution.RepeatedNTimes([2,1,2,5,3,2]), 2),
            ResultTester.CheckResult<int>(solution.RepeatedNTimes([5,1,5,2,5,3,5,4]), 5),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("N-Repeated Element in Size 2N Array");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}