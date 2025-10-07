// Reachable Nodes With Restrictions
namespace CompetitiveProgramming.LeetCode.ReachableNodesWithRestrictions;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int ReachableNodes(int n, int[][] edges, int[] restricted)
    {
        var visited = new HashSet<int> { 0 };
        return 1 + ReachableNodes(0, visited, CreateDicFromEdges(edges), new HashSet<int>(restricted));
    }

    private int ReachableNodes(int node, HashSet<int> visited, Dictionary<int, List<int>> dic, HashSet<int> restricted)
    {
        var rs = 0;
        for (int j = 0; j < dic[node].Count; j++)
        {
            if (!visited.Contains(dic[node][j]) && !restricted.Contains(dic[node][j]))
            {
                visited.Add(dic[node][j]);
                rs += 1 + ReachableNodes(dic[node][j], visited, dic, restricted);
            }
        }
        return rs;
    }
    
    private Dictionary<int, List<int>> CreateDicFromEdges(int[][] edges)
    {
        var dic = new Dictionary<int, List<int>>();
        for (int i = 0; i < edges.Length; i++)
        {
            if (!dic.ContainsKey(edges[i][0]))
            {
                dic.Add(edges[i][0], new List<int> { edges[i][1] });
            }
            else
            {
                dic[edges[i][0]].Add(edges[i][1]);
            }
            if (!dic.ContainsKey(edges[i][1]))
            {
                dic.Add(edges[i][1], new List<int> { edges[i][0] });
            }
            else
            {
                dic[edges[i][1]].Add(edges[i][0]);
            }
        }
        return dic;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Reachable Nodes With Restrictions");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}