// Minimum Distance Between Three Equal Elements II
namespace CompetitiveProgramming.LeetCode.MinimumDistanceBetweenThreeEqualElementsII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinimumDistance(int[] nums)
    {
        var rs = int.MaxValue;
        var dic = new Dictionary<int, List<int>>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!dic.ContainsKey(nums[i]))
            {
                dic.Add(nums[i], new List<int> { i });
            }
            else
            {
                dic[nums[i]].Add(i);
                if (dic[nums[i]].Count > 2)
                {
                    rs = Math.Min(rs, i - dic[nums[i]][dic[nums[i]].Count - 3]);
                }
            }
        }
        return rs != int.MaxValue ? rs * 2 : -1;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.MinimumDistance([1,2,1,1,3]), 6),
            ResultTester.CheckResult<int>(solution.MinimumDistance([1,1,2,3,2,1,2]), 8),
            ResultTester.CheckResult<int>(solution.MinimumDistance([1]), -1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Distance Between Three Equal Elements II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}