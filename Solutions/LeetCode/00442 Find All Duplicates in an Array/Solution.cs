// Find All Duplicates in an Array


using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.FindAllDuplicatesinanArray
{
    public class Solution
    {
        public static IList<int> FindDuplicates(int[] nums)
        {
            IList<int> result = new List<int>();
            
            foreach (int num in nums)
            {
                int index = System.Math.Abs(num) - 1;
                if (nums[index] < 0)
                {
                    result.Add(index + 1);
                }
                else
                {
                    nums[index] = -nums[index];
                }
            }
            
            foreach (int num in nums)
            {
                int index = System.Math.Abs(num) - 1;
                nums[index] = -nums[index];
            }
            
            return result;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Find All Duplicates in an Array");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
        }
    }
}