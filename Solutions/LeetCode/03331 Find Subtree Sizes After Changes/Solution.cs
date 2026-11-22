// Find Subtree Sizes After Changes
namespace CompetitiveProgramming.LeetCode.FindSubtreeSizesAfterChanges;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] FindSubtreeSizes(int[] p, string s)
    {
        int n = p.Length;

        List<int>[] adj = new List<int>[n];
        List<int>[] tree = new List<int>[n];

        for (int i = 0; i < n; i++)
        {
            adj[i] = new List<int>();
            tree[i] = new List<int>();
        }

        int[] ans = new int[n];
        int[] last = Enumerable.Repeat(-1, 26).ToArray();

        for (int i = 1; i < n; i++)
        {
            adj[p[i]].Add(i);
        }

        void Dfs(int u)
        {
            int c = s[u] - 'a';
            int old = last[c];

            if (u != 0 && old != -1)
            {
                p[u] = old;
            }

            last[c] = u;

            foreach (int v in adj[u])
            {
                Dfs(v);
            }

            last[c] = old;
        }

        int Calc(int u)
        {
            int size = 1;

            foreach (int v in tree[u])
            {
                size += Calc(v);
            }

            ans[u] = size;
            return size;
        }

        Dfs(0);

        for (int i = 1; i < n; i++)
        {
            tree[p[i]].Add(i);
        }

        Calc(0);

        return ans;
    }
}

public class Test
{
    public static bool[] TestCases()
    {
        Solution solution = new();
        bool[] results =
        [
            ResultTester.CheckResult<int[]>(solution.FindSubtreeSizes([-1,0,0,1,1,1], "abaabc"), [6,3,1,1,1,1]),
            ResultTester.CheckResult<int[]>(solution.FindSubtreeSizes([-1,0,4,0,1], "abbba"), [5,2,1,1,1]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Find Subtree Sizes After Changes");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
    }
}