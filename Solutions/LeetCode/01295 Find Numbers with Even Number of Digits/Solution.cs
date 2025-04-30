// Find Numbers with Even Number of Digits
namespace CompetitiveProgramming.LeetCode.FindNumberswithEvenNumberofDigits;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int FindNumbers(int[] nums)
    {
        var count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i].ToString().Length % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find Numbers with Even Number of Digits");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}