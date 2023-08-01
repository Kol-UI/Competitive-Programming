using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SumofDistancesinTree
{
    public class Solution
    {
        // There is an undirected connected tree with n nodes labeled from 0 to n - 1 and n - 1 edges.

        //You are given the integer n and the array edges where edges[i] = [ai, bi] indicates that there is an edge between nodes ai and bi in the tree.

        //Return an array answer of length n where answer[i] is the sum of the distances between the ith node in the tree and all other nodes.

        public static int[] SumOfDistancesInTree(int n, int[][] edges)
        {
            var reste = new int[edges.Length + 1];
            var list = new (HashSet<int>, int)[edges.Length + 1];
            for (int i = 0; i < list.Length; i++)
            {
                list[i].Item1 = new HashSet<int>();
                list[i].Item2 = 1;
            }
            for (int i = 0; i < edges.Length; i++)
            {
                list[edges[i][0]].Item1.Add(edges[i][1]);
                list[edges[i][1]].Item1.Add(edges[i][0]);
            }
            for (int i = 0; i < 2; i++)
            {
                SumOfDistancesInTree(0, -1, reste, list, i);
            }
            return reste;
        }
        private static void SumOfDistancesInTree(int node, int parent, int[] reste, (HashSet<int>, int)[] list, int i)
        {
            foreach (int item in list[node].Item1)
            {
                if (item != parent)
                {
                    if (i == 0)
                    {
                        SumOfDistancesInTree(item, node, reste, list, i);
                        list[node].Item2 += list[item].Item2;
                        reste[node] += reste[item] + list[item].Item2;
                    }
                    else
                    {
                        reste[item] = reste[node] + list.Length - list[item].Item2 * 2;
                        SumOfDistancesInTree(item, node, reste, list, i);
                    }
                }
            }
        }
    }

    public class Test
    {
        public static bool[] TestSumofDistancesinTree()
        {
            int n1 = 6;
            int[][] edges1 = new int[][]
            {
                new int[] {0, 1},
                new int[] {0, 2},
                new int[] {2, 3},
                new int[] {2, 4},
                new int[] {2, 5}
            };

            int n2 = 1;
            int[][] edges2 = new int[0][];

            int[] arr1 = new int[] { 8, 12, 6, 10, 10, 10 };
            int[] arr2 = new int[] { 0 };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.SumOfDistancesInTree(n1, edges1), arr1),
                ResultTester.CheckResult<int[]>(Solution.SumOfDistancesInTree(n2, edges2), arr2),
            };

            return results;
        }
    }
}

