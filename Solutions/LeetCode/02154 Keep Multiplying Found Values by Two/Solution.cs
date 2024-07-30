// Keep Multiplying Found Values by Two

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.KeepMultiplyingFoundValuesbyTwo
{
    public class Solution 
    {
        public int FindFinalValue(int[] nums, int original) 
        {
            var set = nums.ToHashSet();

            while (set.Contains(original))
                original *= 2;

            return original;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Keep Multiplying Found Values by Two");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}