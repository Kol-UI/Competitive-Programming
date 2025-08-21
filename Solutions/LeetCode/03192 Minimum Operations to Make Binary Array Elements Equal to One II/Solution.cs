// Minimum Operations to Make Binary Array Elements Equal to One II
namespace CompetitiveProgramming.LeetCode.MinimumOperationstoMakeBinaryArrayElementsEqualtoOneII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinOperations(int[] nums)
    {
        var rs = 0;
        var even = true;
        for (int i = 0; i < nums.Length; i++)
        {
            if (even)
            {
                if (nums[i] == 0)
                {
                    rs++;
                    even = !even;
                }
            }
            else
            {
                if (nums[i] == 1)
                {
                    rs++;
                    even = !even;
                }
            }
        }
        return rs;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        int[] nums1 = { 0, 1, 1, 0, 1 };
        int[] nums2 = { 1, 0, 0, 0 };
        
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<int>(solution.MinOperations(nums1), 4),
            ResultTester.CheckResult<int>(solution.MinOperations(nums2), 1)
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Operations to Make Binary Array Elements Equal to One II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}