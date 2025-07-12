// Minimum Time for K Connected Components
namespace CompetitiveProgramming.LeetCode.MinimumTimeforKConnectedComponents;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    private int nodeCnt;
    private bool LeastK(int[][] edges, int minT, int k)
    {
        HashSet<int>[] adjs = new HashSet<int>[nodeCnt];
        for(int i = 0; i < nodeCnt; i++)
        {
            adjs[i] = new HashSet<int>();
        }

        foreach(int[] edge in edges)
        {
            int n1 = edge[0], n2 = edge[1], t = edge[2];
            if(t > minT)
            {
                adjs[n1].Add(n2);
                adjs[n2].Add(n1);
            }
        }

        bool[] visited = new bool[nodeCnt];
        int cnt = 0;
        for(int i = 0; i < nodeCnt; i++)
        {
            if(visited[i])
                continue;

            cnt++;
            Queue<int> que = new Queue<int>();
            que.Enqueue(i);

            while(que.Count > 0)
            {
                int cur = que.Dequeue();
                visited[cur] = true;

                foreach(int nextN in adjs[cur])
                {
                    if(!visited[nextN])
                        que.Enqueue(nextN);
                }
            }
        }

        return cnt >= k;
    }
    public int MinTime(int n, int[][] edges, int k)
    {
        nodeCnt = n;
        int maxT = 0;
        foreach(int[] cur in edges)
        {
            maxT = Math.Max(maxT, cur[2]);
        }

        int low = 0, high = maxT, res = maxT;
        while(low <= high)
        {
            int mid = low + (high-low)/2;
            if(LeastK(edges, mid, k))
            {
                res = mid;
                high = mid-1;
            }
            else
                low = mid+1;
        }

        return res;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Minimum Time for K Connected Components");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}