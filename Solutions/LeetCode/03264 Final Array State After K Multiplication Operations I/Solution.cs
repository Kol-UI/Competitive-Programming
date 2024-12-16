// Final Array State After K Multiplication Operations I
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.FinalArrayStateAfterKMultiplicationOperationsI
{
    public class Solution
    {
        public int[] GetFinalState(int[] nums, int k, int multiplier)
        {
            for (int i = 0; i < k; i++)
            {
                int x = nums.Min();
                int xIndex = Array.IndexOf(nums, x);
                nums[xIndex] *= multiplier;
            }
            return nums;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(solution.GetFinalState(new int[]{2,1,3,5,6}, 5, 2), new int[]{8,4,6,5,6}),
                ResultTester.CheckResult<int[]>(solution.GetFinalState(new int[]{1,2}, 3, 4), new int[]{16,8}),
            };

            for (int i = 0; i < 737; i++)
            {
                var randomInput = GenerateRandomInput();
                results.Append(ResultTester.CheckResult<int[]>(solution.GetFinalState(randomInput.Item1, randomInput.Item2, randomInput.Item3), solution.GetFinalState(randomInput.Item1, randomInput.Item2, randomInput.Item3)));
            }
            return results;
        }

        public static (int[] nums, int k, int multiplier) GenerateRandomInput()
        {
            Random random = new Random();
            int length = random.Next(1, 101);
            int[] nums = new int[length];
            for (int i = 0; i < length; i++)
            {
                nums[i] = random.Next(1, 101);
            }
            int k = random.Next(1, 11);
            int multiplier = random.Next(1, 6);
            return (nums, k, multiplier);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Final Array State After K Multiplication Operations I");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}