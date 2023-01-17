using System;
using System.IO;

namespace CompetitiveProgramming.LeetCode.LongestPathWithDifferentAdjacentCharacters
{
    public class Solution
    {
        //You are given a tree(i.e.a connected, undirected graph that has no cycles) rooted at node 0 consisting of n nodes numbered from 0 to n - 1.
        //The tree is represented by a 0-indexed array parent of size n, where parent[i] is the parent of node i.
        //Since node 0 is the root, parent[0] == -1.

        //You are also given a string s of length n, where s[i] is the character assigned to node i.

        //Return the length of the longest path in the tree such that no pair of adjacent nodes on the path have the same character assigned to them.

        //Input: parent = [-1,0,0,1,1,2], s = "abacbe"
        //Output: 3
        //Explanation: The longest path where each two adjacent nodes have different characters in the tree is the path: 0 -> 1 -> 3.
        //The length of this path is 3, so 3 is returned.
        //It can be proven that there is no longer path that satisfies the conditions.

        //Input: parent = [-1,0,0,0], s = "aabc"
        //Output: 3
        //Explanation: The longest path where each two adjacent nodes have different characters is the path: 2 -> 0 -> 3. The length of this path is 3, so 3 is returned.

        public static int LongestPath(int[] parent, string s)
        {
            var n = parent.Length;
            var adj = Enumerable.Range(0, n).ToDictionary(x => x, x => new HashSet<int>());
            for (var i = 0; i < n; ++i)
            {
                if (parent[i] != -1)
                {
                    adj[parent[i]].Add(i);
                }
            }
            return LongestPath(0, adj, s).Item1;
        }

        private static (int, int, char) LongestPath(int i, Dictionary<int, HashSet<int>> adj, string s)
        {
            if (!adj[i].Any())
            {
                return (1, 1, s[i]);
            }

            var next = adj[i].Select(x => LongestPath(x, adj, s)).ToArray();
            var different = next.Where(x => x.Item3 != s[i]).OrderByDescending(x => x.Item2).Select(x => x.Item2).Take(2).ToArray();

            return (Math.Max(next.Select(x => x.Item1).Max(), 1 + different.Sum()), (different.Any() ? different.Max() : 0) + 1, s[i]);
        }

    }
}

