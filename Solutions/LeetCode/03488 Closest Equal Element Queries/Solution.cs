// Closest Equal Element Queries
namespace CompetitiveProgramming.LeetCode.ClosestEqualElementQueries;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public IList<int> SolveQueries(int[] nums, int[] queries)
    {
        var map = new Dictionary<int, List<int>>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!map.ContainsKey(nums[i])) map[nums[i]] = new List<int>();
            map[nums[i]].Add(i);
        }
        foreach (var kvp in map) kvp.Value.Sort();

        var result = new int[queries.Length];
        for (int k = 0; k < queries.Length; k++)
        {
            int i = queries[k], val = nums[i];
            var list = map[val];
            if (list.Count < 2)
            {
                result[k] = -1;
                continue;
            }
            int pos = list.BinarySearch(i);
            int left = (pos - 1 + list.Count) % list.Count;
            int right = (pos + 1) % list.Count;
            if (left == pos && right == pos)
            {
                result[k] = -1;
                continue;
            }
            int d1 = Dist(i, list[left], nums.Length);
            int d2 = Dist(i, list[right], nums.Length);
            result[k] = Math.Min(d1, d2);
        }
        return result;
    }

    int Dist(int i, int j, int n)
    {
        int diff = Math.Abs(i - j);
        return Math.Min(diff, n - diff);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Closest Equal Element Queries");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}