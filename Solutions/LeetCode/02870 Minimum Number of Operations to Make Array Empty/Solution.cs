// Minimum Number of Operations to Make Array Empty

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.MinimumNumberofOperationstoMakeArrayEmpty
{
    public class Solution
    {
        public static int MinOperations(int[] nums)
        {
            var values = CreateMinOperationsDictionary(nums);
            var result = 0;

            foreach (var item in values)
            {
                if (item.Value == 1)
                {
                    return -1;
                }
                if (item.Value % 3 == 0)
                {
                    result += item.Value / 3;
                }
                else
                {
                    result += item.Value / 3 + 1;
                }
            }

            return result;
        }

        private static Dictionary<int, int> CreateMinOperationsDictionary(int[] nums)
        {
            var values = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!values.ContainsKey(nums[i]))
                {
                    values.Add(nums[i], 0);
                }
                values[nums[i]]++;
            }
            
            return values;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MinOperations(new int[] {2,3,3,2,2,4,2,3,4}), 4),
                ResultTester.CheckResult<int>(Solution.MinOperations(new int[] {2,1,2,2,3,3}), -1),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Minimum Number of Operations to Make Array Empty");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}