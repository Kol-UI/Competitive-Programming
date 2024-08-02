// Count Elements With Maximum Frequency

using System;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.CountElementsWithMaximumFrequency
{
    public class Solution
    {
        public static int MaxFrequencyElements(int[] nums)
        {
            var dic = CreateFrequencyDic(nums);
            var maxFrequency = 0;
            foreach (var item in dic)
            {
                maxFrequency = Math.Max(maxFrequency, item.Value);
            }
            var rs = 0;
            foreach (var item in dic)
            {
                if (item.Value == maxFrequency) rs += item.Value;
            }
            return rs;
        }

        private static Dictionary<int, int> CreateFrequencyDic(int[] nums)
        {
            var rs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!rs.ContainsKey(nums[i])) rs.Add(nums[i], 0);
                rs[nums[i]]++;
            }
            return rs;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(Solution.MaxFrequencyElements(new int[]{1,2,2,3,1,4}), 4),
                ResultTester.CheckResult<int>(Solution.MaxFrequencyElements(new int[]{1,2,3,4,5}), 5),
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("3005");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
        }
    }
}