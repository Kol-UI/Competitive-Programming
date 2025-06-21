// Count the Number of Complete Components
namespace CompetitiveProgramming.LeetCode.CounttheNumberofCompleteComponents;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution {

    public class UnionFind
    {
        public int[] Parent;
        public int[] Rank;
        public int[] Size;
        public int[] EdgeCount;

        public UnionFind(int n)
        {
            Parent = new int[n];
            Rank = new int[n];
            Size = new int[n];
            EdgeCount = new int[n];        

            for(int i = 0; i < n; i++)
            {
                Parent[i] = i;
                Size[i] = 1;
            }
        }

        public int Find(int i)
        {
            if(Parent[i] == i)
                return i;
            
            Parent[i] = Find(Parent[i]);
            return Parent[i];
        }

        public void Union(int i, int j)
        {
            int pi = Find(i);
            int pj = Find(j);

            if(pi != pj)
            {
                if(Rank[pi] > Rank[pj])
                {
                    Parent[pj] = pi;
                    Size[pi] +=  Size[pj];
                    EdgeCount[pi] += EdgeCount[pj] + 1;
                }
                else if(Rank[pj] > Rank[pi])
                {
                    Parent[pi] = pj;
                    Size[pj] += Size[pi];
                    EdgeCount[pj] += EdgeCount[pi] + 1;
                }
                else
                {
                    Parent[pj] = pi;    
                    Size[pi] += Size[pj];
                    EdgeCount[pi] += EdgeCount[pj] + 1;
                    Rank[pi]++;
                }
            }
            else
            {
                EdgeCount[pi]++;
            }
        }
    }

    public int CountCompleteComponents(int n, int[][] edges) {
        
        UnionFind uf = new UnionFind(n);
        foreach(var edge in edges)
        {
            uf.Union(edge[0], edge[1]);
        }

        int result = 0;
        for(int i = 0; i < uf.Parent.Length; i++)
        {        
            if(i == uf.Parent[i] && uf.EdgeCount[i] == (uf.Size[i] * (uf.Size[i] - 1) / 2))
            {
                result++;      
            }
        }

        return result;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Count the Number of Complete Components");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}