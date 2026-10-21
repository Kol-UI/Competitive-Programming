// Remove Duplicates from Sorted Array II
namespace CompetitiveProgramming.LeetCode.RemoveDuplicatesfromSortedArrayII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int result = 1;
        int count = 1;

        for (int i = 1; i < nums.Length; i ++)
        {
            if(nums[i] == nums[i-1]) count ++;
            else count = 1;

            if (count <= 2)
            {
                nums[result] = nums[i];
                result++;
            }
        }

        return result;
    }
}
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Remove Duplicates from Sorted Array II");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}