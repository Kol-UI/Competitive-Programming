// Most Frequent IDs
namespace CompetitiveProgramming.LeetCode.MostFrequentIDs;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long[] MostFrequentIDs(int[] nums, int[] freq)
    {
        List<long> ans = new List<long>();
        int n = nums.Length;
        PriorityQueue<long, long> pq = new PriorityQueue<long, long>(Comparer<long>.Create((x, y) => y.CompareTo(x)));
        Dictionary<long, long> dict = new Dictionary<long, long>();

        for (int i = 0; i < n; i++)
        {
            if (dict.ContainsKey(nums[i]))
                dict[nums[i]] += freq[i];
            else
                dict[nums[i]] = freq[i];

            pq.Enqueue(nums[i], dict[nums[i]]);

            while (true)
            {
                pq.TryPeek(out long val, out long priorityval);
                if (priorityval == dict[val])
                {
                    ans.Add(priorityval);
                    break;
                }
                else
                    pq.Dequeue();
            }
        }

        return ans.ToArray();
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results = new bool[]
        {
            ResultTester.CheckResult<long[]>(solution.MostFrequentIDs([2,3,2,1], [3,2,-3,1]), [3,3,2,2]),
            ResultTester.CheckResult<long[]>(solution.MostFrequentIDs([5,5,3], [2,-2,1]), [2,0,1]),
        };
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Most Frequent IDs");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}