// Continuous Subarrays
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.ContinuousSubarrays
{
    public class Solution
    {
        public long ContinuousSubarrays(int[] nums)
        {
            long result = 0;
            int len = nums.Length;

            var sortedList = new SortedList<int, int>();
            int i = 0, j = 0;

            while (i <= j && j < len)
            {
                sortedList[nums[j]] = sortedList.GetValueOrDefault(nums[j], 0) + 1;

                while (Math.Abs(sortedList.Keys[0] - sortedList.Keys[^1]) > 2)
                {
                    sortedList[nums[i]]--;

                    if (sortedList[nums[i]] == 0)
                    {
                        sortedList.Remove(nums[i]);
                    }
                    i++;
                }

                result += j - i + 1;
                j++;
            }
            
            return result;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            Solution solution = new();

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(solution.ContinuousSubarrays(new int[]{5,4,2,4}), 8),
                ResultTester.CheckResult<long>(solution.ContinuousSubarrays(new int[]{1,2,3}), 6)
            };

            for (int i = 0; i < 2135; i++)
            {
                int[] ints = GenerateRandomArray(10, 1, 15);
                results.Append(ResultTester.CheckResult<long>(solution.ContinuousSubarrays(ints), solution.ContinuousSubarrays(ints)));
            }

            return results;
        }

        private static int[] GenerateRandomArray(int size, int minValue, int maxValue)
        {
            Random random = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(minValue, maxValue + 1);
            }
            return array;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Continuous Subarrays");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}