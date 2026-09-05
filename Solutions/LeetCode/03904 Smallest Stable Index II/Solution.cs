// Smallest Stable Index II
namespace CompetitiveProgramming.LeetCode.SmallestStableIndexII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int FirstStableIndex(int[] nums, int k)
    {
        var pq1 = new PriorityQueue<int, int>();
        var pq2 = new PriorityQueue<int, int>();
        var deleted = new Dictionary<int, int>();
        var len = nums.Length;
        foreach (var num in nums) pq2.Enqueue(num, num);
        for (var i = 0; i < len; ++i)
        {
            var num = nums[i];
            pq1.Enqueue(num, -num);
            var max = pq1.Peek();
            var min = pq2.Peek();
            while (deleted.ContainsKey(min) && deleted[min] > 0)
            {
                deleted[min]--;
                pq2.Dequeue();
                min = pq2.Peek();
            }            
            if (max - min <= k) return i;
            if (deleted.ContainsKey(num)) deleted[num]++;
            else deleted[num] = 1;
        }
        return -1;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solution.FirstStableIndex([5,0,1,4], 3), 3),
            ResultTester.CheckResult<int>(solution.FirstStableIndex([3,2,1], 1), -1),
            ResultTester.CheckResult<int>(solution.FirstStableIndex([0], 0), 0),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Smallest Stable Index II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}