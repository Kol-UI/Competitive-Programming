// Maximum Number of Eaten Apples
namespace CompetitiveProgramming.LeetCode.MaximumNumberofEatenApples;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class SolutionPriorityQueue
{
    public int EatenApples(int[] apples, int[] days)
    {
        var pQueue = new PriorityQueue<(int apple, int rotten), int>();
        int appleEatingDay = 0;
        int currDay = 0;

        for (currDay = 0; currDay < apples.Length; currDay++)
        {
            int rottenDays = currDay + days[currDay];
            pQueue.Enqueue((apples[currDay], rottenDays), rottenDays);

            while (pQueue.Count != 0)
            {
                var cItem = pQueue.Dequeue();
                if (cItem.rotten < currDay + 1)
                    continue;

                cItem.apple -= 1;
                ++appleEatingDay;

                if (cItem.apple > 0)
                    pQueue.Enqueue(cItem, cItem.rotten);

                break;
            }
        }

        while (pQueue.Count != 0)
        {
            var cItem = pQueue.Dequeue();
            if (cItem.rotten < currDay + 1)
                continue;

            cItem.apple -= 1;
            ++appleEatingDay;

            if (cItem.apple > 0)
                pQueue.Enqueue(cItem, cItem.rotten);

            ++currDay;
        }

        return appleEatingDay;
    }
}

public class SolutionPriorityQueueHash
{
    public int EatenApples(int[] apples, int[] days)
    {
        PriorityQueue<int, int> pq = new();
        Dictionary<int, int> maxMap = new();
        int tot = 0;

        for (int i = 0; i < apples.Length; ++i)
        {
            int max = i + days[i] - 1;
            int cnt = apples[i];

            int nearest = 0;
            while (pq.Count > 0 && (nearest = pq.Peek()) < i)
            {
                pq.Dequeue();
                maxMap.Remove(nearest);
            }

            if (pq.Count == 0)
            {
                if (cnt > 0)
                {
                    tot++;
                    if (cnt > 1)
                    {
                        pq.Enqueue(max, max);
                        maxMap.TryAdd(max, 0);
                        maxMap[max] += cnt - 1;
                    }
                }

                continue;
            }

            tot++;
            nearest = pq.Peek();

            if (cnt == 0 || days[i] == 0 || nearest <= max)
            {
                maxMap[nearest]--;
                if (maxMap[nearest] == 0)
                {
                    maxMap.Remove(nearest);
                    pq.Dequeue();
                }
            }
            else
            {
                cnt--;
            }

            if (cnt == 0)
            {
                continue;
            }

            if (!maxMap.ContainsKey(max))
            {
                maxMap[max] = cnt;
                pq.Enqueue(max, max);
            }
            else
            {
                maxMap[max] += cnt;
            }
        }

        int prev = days.Length - 1;
        while (pq.Count > 0)
        {
            int next = pq.Dequeue();
            int remn = maxMap[next];
            int min = Math.Min(next, prev + remn);
            tot += min - prev;
            prev = min;
        }

        return tot;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        SolutionPriorityQueue solutionPriorityQueue = new();
        SolutionPriorityQueueHash solutionPriorityQueueHash = new();
        bool[] results =
        [
            ResultTester.CheckResult<int>(solutionPriorityQueue.EatenApples([1,2,3,5,2], [3,2,1,4,2]), 7),
            ResultTester.CheckResult<int>(solutionPriorityQueue.EatenApples([3,0,0,0,0,2], [3,0,0,0,0,2]), 5),
            ResultTester.CheckResult<int>(solutionPriorityQueueHash.EatenApples([1,2,3,5,2], [3,2,1,4,2]), 7),
            ResultTester.CheckResult<int>(solutionPriorityQueueHash.EatenApples([3,0,0,0,0,2], [3,0,0,0,0,2]), 5),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Maximum Number of Eaten Apples");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}