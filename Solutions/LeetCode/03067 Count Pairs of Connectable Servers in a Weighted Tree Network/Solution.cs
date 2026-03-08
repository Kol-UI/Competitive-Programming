// Count Pairs of Connectable Servers in a Weighted Tree Network
namespace CompetitiveProgramming.LeetCode.CountPairsofConnectableServersinaWeightedTreeNetwork;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] CountPairsOfConnectableServers(int[][] edges, int signalSpeed)
    {
        int items = edges.Length;
        int[] res = new int[items + 1];
        List<(int, int)>[] paths = new List<(int, int)>[items + 1];

        for (int i = 0; i < items + 1; i++)
        {
            List<(int, int)> itm = new List<(int, int)>();
            paths[i] = itm;
        }

        for (int i = 0; i < items; i++)
        {
            int pos = edges[i][0];
            int pos2 = edges[i][1];

            paths[pos].Add((edges[i][1], edges[i][2]));
            paths[pos2].Add((edges[i][0], edges[i][2]));
        }

        int thisPos = 0;
        HashSet<int> visited = new HashSet<int>();
        while (thisPos < items + 1)
        {
            visited = new HashSet<int>();
            List<(int, int)> thisItems = paths[thisPos];

            List<int> sums = new List<int>();
            visited.Add(thisPos);
            if (thisItems.Count < 2)
            {
                res[thisPos] = 0;
                thisPos++;
                continue;
            }
            for (int i = 0; i < thisItems.Count; i++)
            {
                int val = 0;
                int couuu = 0;

                Queue<((int, int), int)> points = new Queue<((int, int), int)>();

                if (!visited.Contains(thisItems[i].Item1))
                    points.Enqueue((thisItems[i], thisItems[i].Item2));

                visited.Add(thisItems[i].Item1);

                while (points.Count > 0)
                {
                    ((int, int), int) iittm = points.Dequeue();
                    val = iittm.Item2;
                    int edge = iittm.Item1.Item1;

                    visited.Add(iittm.Item1.Item1);

                    List<(int, int)> nItms = paths[edge];

                    if (val % signalSpeed == 0)
                        couuu++;

                    foreach (var item in nItms)
                    {
                        if (!visited.Contains(item.Item1))
                        {
                            points.Enqueue((item, val + item.Item2));
                        }
                    }
                }

                sums.Add(couuu);
            }
            int resss = 0;
            int sumss = sums.Sum();
            for (int z = 0; z < sums.Count; z++)
            {
                resss += (sumss - sums[z]) * sums[z];
            }
            res[thisPos] = resss / 2;
            thisPos++;
        }

        return res;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        var edges1 = new int[][] { [0,1,1],[1,2,5],[2,3,13],[3,4,9],[4,5,2] };
        int signalSpeed1 = 1;
        int[] expected1 = [0,4,6,6,4,0];

        var edges2 = new int[][] { [0,6,3],[6,5,3],[0,3,1],[3,2,7],[3,1,6],[3,4,2] };
        int signalSpeed2 = 3;
        int[] expected2 = [2, 0, 0, 0, 0, 0, 2];
        
        bool[] results =
        [
            ResultTester.CheckResult<int[]>(solution.CountPairsOfConnectableServers(edges1, signalSpeed1), expected1),
            ResultTester.CheckResult<int[]>(solution.CountPairsOfConnectableServers(edges2, signalSpeed2), expected2),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count Pairs of Connectable Servers in a Weighted Tree Network");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}