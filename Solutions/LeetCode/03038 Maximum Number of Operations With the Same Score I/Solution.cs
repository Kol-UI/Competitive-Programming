// Maximum Number of Operations With the Same Score I


using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MaximumNumberofOperationsWiththeSameScoreI
{
    public class Solution
    {
        public static int MaxOperations(int[] nums)
        {
            int sumOfRemovedValues = nums[0] + nums[1];

            int count = 0;

            while (nums.Length >= 2)
            {
                if (nums[0] + nums[1] == sumOfRemovedValues)
                {
                    nums = nums.Skip(2).ToArray();

                    count++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MaxOperations(new int[]{3,2,1,4,5}), 2),
                ResultTester.CheckResult<int>(Solution.MaxOperations(new int[]{3,2,6,1,4}), 1),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Maximum Number of Operations With the Same Score I");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}