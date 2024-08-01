// Checking Existence of Edge Length Limited Paths

/*
An undirected graph of n nodes is defined by edgeList, where edgeList[i] = [ui, vi, disi] denotes an edge between nodes ui and vi with distance disi. Note that there may be multiple edges between two nodes.

Given an array queries, where queries[j] = [pj, qj, limitj], your task is to determine for each queries[j] whether there is a path between pj and qj such that each edge on the path has a distance strictly less than limitj .

Return a boolean array answer, where answer.length == queries.length and the jth value of answer is true if there is a path for queries[j] is true, and false otherwise.

 

Example 1:


Input: n = 3, edgeList = [[0,1,2],[1,2,4],[2,0,8],[1,0,16]], queries = [[0,1,2],[0,2,5]]
Output: [false,true]
Explanation: The above figure shows the given graph. Note that there are two overlapping edges between 0 and 1 with distances 2 and 16.
For the first query, between 0 and 1 there is no path where each distance is less than 2, thus we return false for this query.
For the second query, there is a path (0 -> 1 -> 2) of two edges with distances less than 5, thus we return true for this query.

Example 2:


Input: n = 5, edgeList = [[0,1,10],[1,2,5],[2,3,9],[3,4,13]], queries = [[0,4,14],[1,4,13]]
Output: [true,false]
Exaplanation: The above figure shows the given graph.
 

Constraints:

2 <= n <= 105
1 <= edgeList.length, queries.length <= 105
edgeList[i].length == 3
queries[j].length == 3
0 <= ui, vi, pj, qj <= n - 1
ui != vi
pj != qj
1 <= disi, limitj <= 109
There may be multiple edges between two nodes.
*/

using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CheckingExistenceofEdgeLengthLimitedPaths
{
    public class Solution
    {
        // Union Find
        
        public static bool[] DistanceLimitedPathsExist(int n, int[][] edgeList, int[][] queries)
        {
            int edgesCount = edgeList.Length;
            int queriesCount = queries.Length;
            DSU dsu = new DSU(n);

            for (int i = 0; i < queriesCount; i++)
            {
                queries[i] = new int[]
                {
                    queries[i][0], 
                    queries[i][1], 
                    queries[i][2],
                    i
                }; 
            }

            Array.Sort(queries, (a, b) => a[2] - b[2]);
            Array.Sort(edgeList, (a, b) => a[2] - b[2]);
            bool[] res = new bool[queriesCount];

            for (int i = 0, j = 0; i < queriesCount; i++)
            {
                var query = queries[i];

                while (j < edgesCount && edgeList[j][2] < queries[i][2])
                {
                    dsu.union(edgeList[j][0], edgeList[j++][1]);
                }

                res[queries[i][3]] = dsu.find(queries[i][0]) == dsu.find(queries[i][1]);
            }

            return res;
        }

        class DSU 
        {
            public int[] parent;

            public DSU(int n) 
            {
                parent = new int[n];

                for (int i = 0; i < n; i++) parent[i] = i;
            }

            public int find(int x) 
            {
                if (parent[x] != x) parent[x] = find(parent[x]);
                return parent[x];
            }

            public void union(int x, int y)
            {
                parent[find(x)] = parent[find(y)];
            }
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int n1 = 3;
            int[][] edgeList1 = new int[][]
            {
                new int[] { 0,1,2 },
                new int[] { 1,2,4 },
                new int[] { 2,0,8 },
                new int[] { 1,0,16 }
            };

            int[][] queries1 = new int[][]
            {
                new int[] { 0, 1, 2 },
                new int[] { 0, 2, 5 }
            };

            int n2 = 5;
            int[][] edgeList2 = new int[][]
            {
                new int[] {0,1,10},
                new int[] {1,2,5},
                new int[] {2,3,9},
                new int[] {3,4,13}
            };

            int[][] queries2 = new int[][]
            {
                new int[] {0,4,14},
                new int[] {1,4,13}
            };

            bool[] result1 = Solution.DistanceLimitedPathsExist(n1, edgeList1, queries1);
            bool[] expected1 = {false, true};
            bool[] result2 = Solution.DistanceLimitedPathsExist(n2, edgeList2, queries2);
            bool[] expected2 = {true, false};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<bool[]>(result1, expected1),
                ResultTester.CheckResult<bool[]>(result2, expected2)
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Checking Existence of Edge Length limited Paths");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.HardLC, Test.TestCases());
        }
    }
}