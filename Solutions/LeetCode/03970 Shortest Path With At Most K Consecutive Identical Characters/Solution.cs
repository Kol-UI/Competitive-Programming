// Shortest Path With At Most K Consecutive Identical Characters
namespace CompetitiveProgramming.LeetCode.ShortestPathWithAtMostKConsecutiveIdenticalCharacters;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {
    public int ShortestPath(int n, int[][] edges, string labels, int k) {
        var g = new List<(int y, int w)>[n];
        for (int i = 0; i < n; i++) {
            g[i] = new List<(int, int)>();
        }
        foreach (var e in edges) {
            g[e[0]].Add((e[1], e[2]));
        }

        long[,] dis = new long[n, k + 1];
        for (int i = 0; i < n; i++) {
            for (int j = 0; j <= k; j++) {
                dis[i, j] = int.MaxValue;
            }
        }
        var pq = new PriorityQueue<(long d, int x, int cnt), long>();

        dis[0, 1] = 0;
        pq.Enqueue((0, 0, 1), 0);

        while (pq.Count > 0) {
            var (d, x, cnt) = pq.Dequeue();

            if (d > dis[x, cnt]) {
                continue;
            }
            if (x == n - 1) {
                return (int)d;
            }

            foreach (var (y, w) in g[x]) {
                int newCnt = labels[x] == labels[y] ? cnt + 1 : 1;
                if (newCnt > k) {
                    continue;
                }

                long nd = d + w;
                if (nd < dis[y, newCnt]) {
                    dis[y, newCnt] = nd;
                    pq.Enqueue((nd, y, newCnt), nd);
                }
            }
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
            ResultTester.CheckResult<int>(solution.ShortestPath(3, [[0,1,1],[1,2,1],[0,2,3]], "aab", 1), 3),
            ResultTester.CheckResult<int>(solution.ShortestPath(3, [[0,1,1],[1,2,1]], "aaa", 2), -1),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Shortest Path With At Most K Consecutive Identical Characters");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}