// Make Array Elements Equal to Zero
namespace CompetitiveProgramming.LeetCode.MakeArrayElementsEqualtoZero;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

public class Solution
{
    public int CountValidSelections(int[] nums)
    {
        int count = 0, nonZeros = nums.Count(x => x > 0), n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            if (nums[i] == 0)
            {
                if (IsValid(nums, nonZeros, i, -1))
                    count++;
                if (IsValid(nums, nonZeros, i, 1))
                    count++;
            }
        }
        return count;
    }

    bool IsValid(int[] nums, int nonZeros, int start, int direction)
    {
        int n = nums.Length;
        int[] temp = (int[])nums.Clone();
        int curr = start;
        while (nonZeros > 0 && curr >= 0 && curr < n)
        {
            if (temp[curr] > 0)
            {
                temp[curr]--;
                direction *= -1;
                if (temp[curr] == 0)
                    nonZeros--;
            }
            curr += direction;
        }
        return nonZeros == 0;
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Make Array Elements Equal to Zero");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}