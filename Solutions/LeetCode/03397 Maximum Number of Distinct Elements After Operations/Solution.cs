// Maximum Number of Distinct Elements After Operations
namespace CompetitiveProgramming.LeetCode.MaximumNumberofDistinctElementsAfterOperations;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxDistinctElements(int[] nums, int k)
    {
        Array.Sort(nums);
        HashSet<int> hs = new();
        int curr = nums[0] - k;
        hs.Add(curr);

        for (int i = 1; i < nums.Length; i++)
        {
            curr = Math.Max(Math.Min(curr + 1, nums[i] + k), nums[i] - k);
            if (curr <= nums[i] + k) hs.Add(curr);
        }

        return hs.Count;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MaxDistinctElements([1,2,2,3,3,4], 2), 6),
            ResultTester.CheckResult<int>(solution.MaxDistinctElements([4,4,4,4], 1), 3)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Number of Distinct Elements After Operations");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}