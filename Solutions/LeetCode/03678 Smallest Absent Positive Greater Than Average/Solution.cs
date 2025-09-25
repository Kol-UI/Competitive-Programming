// Smallest Absent Positive Greater Than Average
namespace CompetitiveProgramming.LeetCode.SmallestAbsentPositiveGreaterThanAverage;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {
    public int SmallestAbsent(int[] nums) => Enumerable.Range(1, 101)
        .Except(nums)
        .FirstOrDefault(m => m > (int)Math.Floor(nums.Average()));
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Smallest Absent Positive Greater Than Average");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
    }
}