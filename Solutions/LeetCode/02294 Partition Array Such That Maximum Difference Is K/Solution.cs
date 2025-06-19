// Partition Array Such That Maximum Difference Is K
namespace CompetitiveProgramming.LeetCode.PartitionArraySuchThatMaximumDifferenceIsK;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int PartitionArray(int[] nums, int k)
    {
        Array.Sort(nums);
        int cnt = 1;
        int val = nums[0];
        for(int i = 1; i < nums.Length; i++)
        {
            if(nums[i] - val <= k) continue;
            cnt++;
            val = nums[i];
        }
        return cnt;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.PartitionArray(new int[]{3,6,1,2,5}, 2), 2),
            ResultTester.CheckResult<int>(solution.PartitionArray(new int[]{1,2,3}, 1), 2),
            ResultTester.CheckResult<int>(solution.PartitionArray(new int[]{2,2,4,5}, 0), 3),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Partition Array Such That Maximum Difference Is K");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}