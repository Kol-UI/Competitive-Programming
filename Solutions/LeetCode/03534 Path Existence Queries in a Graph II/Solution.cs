// Path Existence Queries in a Graph II
namespace CompetitiveProgramming.LeetCode.PathExistenceQueriesinaGraphII;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[] PathExistenceQueries(int n, int[] nums, int maxDiff, int[][] queries)
    {
        int[][] pairs = new int[n][];

        for(int i=0; i<n; i++)
            pairs[i] = new int[]{nums[i],i};
        
        Array.Sort(pairs, (a,b)=>a[0].CompareTo(b[0]));

        const int LOG = 20;
        int[][] jump = new int[n][];

        for(int i=0; i<n; i++)
            jump[i] = new int[LOG];
        
        int right = n-1;

        for(int left = n-1; left >=0; left--)
        {
            while(pairs[right][0] - pairs[left][0] > maxDiff)
                right--;
            
            int u = pairs[left][1];
            int v = pairs[right][1];

            jump[u][0] = v;

            for(int k=1; k<LOG; k++)
                jump[u][k] = jump[jump[u][k-1]][k-1];
        }

        int[] ans = new int[queries.Length];

        for(int t=0; t<queries.Length; t++)
        {
            int u = queries[t][0];
            int v = queries[t][1];

            if(nums[u] > nums[v])
                (u,v) = (v,u);

            if(u==v)
            {
                ans[t] = 0;
                continue;
            }

            if(nums[u] == nums[v])
            {
                ans[t] = 1;
                continue;
            }

            int dist = 0;

            for(int k = LOG-1; k>=0; k--)
            {
                if(nums[jump[u][k]] < nums[v])
                {
                    dist += (1 << k);
                    u = jump[u][k];
                }
            }

            if(nums[jump[u][0]] < nums[v])  
                ans[t] = -1;
            else
                ans[t] = dist +1;
        }
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
            ResultTester.CheckResult<int[]>(solution.PathExistenceQueries(5, [1,8,3,4,2], 3, [[0,3],[2,4]]), [1,1]),
            ResultTester.CheckResult<int[]>(solution.PathExistenceQueries(5, [5,3,1,9,10], 2, [[0,1],[0,2],[2,3],[4,3]]), [1,2,-1,1]),
            ResultTester.CheckResult<int[]>(solution.PathExistenceQueries(3, [3,6,1], 1, [[0,0],[0,1],[1,2]]), [0,-1,-1]),
        ];
        return results;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Path Existence Queries in a Graph II");
        ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
    }
}