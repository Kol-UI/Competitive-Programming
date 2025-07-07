// Maximum Number of Events That Can Be Attended
namespace CompetitiveProgramming.LeetCode.MaximumNumberofEventsThatCanBeAttended;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MaxEvents(int[][] events)
    {
       Array.Sort(events, (x, y) => x[0] == y[0] ? x[1] - y[1] : x[0] - y[0]);
        var pq = new PriorityQueue<int, int>();
        
        var count = 0;
        var availableDay = 1;
        foreach (var e in events)
        {
            while (pq.TryPeek(out var start, out var end) && Math.Max(start, availableDay) < e[0])
            {
                var s = pq.Dequeue();
                if (end >= availableDay)
                {
                    count++;
                    availableDay = Math.Max(s + 1, availableDay + 1);   
                }
            }
            
            pq.Enqueue(e[0], e[1]);
        }

        while (pq.TryDequeue(out var start, out var end))
        {
            if (end >= availableDay)
            {
                count++;
                availableDay = Math.Max(start + 1, availableDay + 1);
            }
        }

        return count;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Number of Events That Can Be Attended");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}