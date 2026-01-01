// Sort Array By Parity II
namespace CompetitiveProgramming.LeetCode.SortArrayByParityII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] SortArrayByParityII(int[] nums)
    {
        if(nums.Length == 0)
        {
            return new int[0];
        }

        int e = 0;
        int o = 1;
        while(e < nums.Length && o < nums.Length)
        {
            if(nums[e] % 2 == 0) e += 2;
            if(nums[o] %2 != 0) o += 2;
            else
            {
                int t = nums[e];
                nums[e] = nums[o];
                nums[o] = t;
            }
        }
        return nums;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sort Array By Parity II");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}