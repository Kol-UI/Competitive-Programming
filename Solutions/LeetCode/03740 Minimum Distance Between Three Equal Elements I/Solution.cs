// Minimum Distance Between Three Equal Elements I
namespace CompetitiveProgramming.LeetCode.MinimumDistanceBetweenThreeEqualElementsI;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MinimumDistance(int[] nums)
    {
        var dict = new Dictionary<int, List<int>>();
        var res = int.MaxValue;
        for (var i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                dict[nums[i]].Add(i);
                if (dict[nums[i]].Count >= 3)
                {
                    var l = dict[nums[i]];
                    var start = l.Count - 3;
                    var dis = Math.Abs((l[start] - l[start + 1])) + Math.Abs((l[start + 1] - l[start + 2])) + Math.Abs((l[start + 2] - l[start]));
                    if (dis < res)
                    {
                        res = dis;
                    }
                }
                continue;
            }
            dict.Add(nums[i], new List<int>() { i });
        }
        if (res == int.MaxValue)
        {
            return -1;
        }
        return res;
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
        StyleHelper.Title("Minimum Distance Between Three Equal Elements I");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.EasyLC, Test.TestCases());
    }
}