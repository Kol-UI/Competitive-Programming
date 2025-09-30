// Find Triangular Sum of an Array
namespace CompetitiveProgramming.LeetCode.FindTriangularSumofanArray;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int TriangularSum(int[] nums)
    {
        int n = nums.Length;
        for (int size = n; size > 1; size--)
        {
            for (int i = 0; i < size - 1; i++)
            {
                nums[i] = (nums[i] + nums[i + 1]) % 10;
            }
        }
        return nums[0];
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find Triangular Sum of an Array");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}