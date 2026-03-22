// Total Score of Dungeon Runs
namespace CompetitiveProgramming.LeetCode.TotalScoreofDungeonRuns;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long TotalScore(int hp, int[] damage, int[] requirement)
    {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
        int len = damage.Length;
        int pre = hp;
        HashSet<int> restIds = new();
        for (int i = 0; i < len; i++)
        {
            int d = damage[i], r = requirement[i];
            pre -= d;
            if (pre < r)
            {
                pq.Enqueue(i, pre - r);
                restIds.Add(i);
            }
        }

        int pqLen = pq.Count;
        pre = 0;
        if (pqLen == 0)
            return (long)(len + 1) * len / 2;

        long res = len - restIds.Count;

        for (int i = 1; i < len; i++)
        {
            pre += damage[i - 1];
            restIds.Remove(i - 1);

            while (pq.Count > 0 && pq.TryPeek(out int id, out int val) && pre + val >= 0)
            {
                pq.Dequeue();
                restIds.Remove(id);
            }

            int cnt = len - i - restIds.Count;
            res += cnt;
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
            ResultTester.CheckResult<long>(solution.TotalScore(11, [3,6,7], [4,2,5]), 3),
            ResultTester.CheckResult<long>(solution.TotalScore(2, [10000,1], [1,1]), 1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Total Score of Dungeon Runs");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}