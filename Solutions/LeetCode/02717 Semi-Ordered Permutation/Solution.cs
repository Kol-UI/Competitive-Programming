// Semi-Ordered Permutation


using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.SemiOrderedPermutation
{
    public class Solution
    {
        public static int SemiOrderedPermutation(int[] nums)
        {
            var leftIndex = -1;
            var rightIndex = -1;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    leftIndex = i;
                }
                else if (nums[i] == nums.Length)
                {
                    rightIndex = i;
                }
                else if (leftIndex != -1 && rightIndex != -1)
                {
                    break;
                }
            }

            if (leftIndex == 0 && rightIndex == nums.Length - 1)
            {
                return 0;
            }

            return leftIndex + (nums.Length - rightIndex - 1) + (leftIndex > rightIndex ? -1 : 0);
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.SemiOrderedPermutation(new int[]{2,1,4,3}), 2),
                ResultTester.CheckResult<int>(Solution.SemiOrderedPermutation(new int[]{2,4,1,3}), 3),
                ResultTester.CheckResult<int>(Solution.SemiOrderedPermutation(new int[]{1,3,4,2,5}), 0),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("2717");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}