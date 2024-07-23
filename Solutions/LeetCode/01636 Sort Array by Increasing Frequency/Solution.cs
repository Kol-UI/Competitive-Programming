// Sort Array by Increasing Frequency

using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SortArraybyIncreasingFrequency
{
    public class Solution
    {
        public int[] FrequencySort(int[] nums) =>
            nums.GroupBy(v => v)
                .OrderBy(g => g.Count()).ThenByDescending(g => g.Key)
                .SelectMany(g => g).ToArray();
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Sort Array by Increasing Frequency");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.EasyLC);
        }
    }
}