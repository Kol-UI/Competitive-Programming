// Minimum Time to Repair Cars
namespace CompetitiveProgramming.LeetCode.MinimumTimetoRepairCars;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public long RepairCars(int[] ranks, int cars)
    {
        var pq = new PriorityQueue<(int, int), long>();
        for (int i = 0; i < ranks.Length; i++)
        {
            pq.Enqueue((ranks[i], 1), ranks[i]);
        }

        long max = 0;
        while (cars > 0)
        {
            var tuple = pq.Dequeue();
            var time = (long)tuple.Item1 * tuple.Item2 * tuple.Item2;
            tuple.Item2 += 1;
            max = Math.Max(max, time);
            pq.Enqueue((tuple.Item1, tuple.Item2), (long)tuple.Item1 * tuple.Item2 * tuple.Item2);
            cars--;
        }

        return max;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Time to Repair Cars");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}