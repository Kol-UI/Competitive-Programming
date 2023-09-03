// Sort Items by Groups Respecting Dependencies

/*
There are n items each belonging to zero or one of m groups where group[i] is the group that the i-th item belongs to and it's equal to -1 if the i-th item belongs to no group. The items and the groups are zero indexed. A group can have no item belonging to it.

Return a sorted list of the items such that:

The items that belong to the same group are next to each other in the sorted list.
There are some relations between these items where beforeItems[i] is a list containing all the items that should come before the i-th item in the sorted array (to the left of the i-th item).
Return any solution if there is more than one solution and return an empty list if there is no solution.

 

Example 1:

Input: n = 8, m = 2, group = [-1,-1,1,0,0,1,0,-1], beforeItems = [[],[6],[5],[6],[3,6],[],[],[]]
Output: [6,3,4,1,5,2,0,7]

Example 2:

Input: n = 8, m = 2, group = [-1,-1,1,0,0,1,0,-1], beforeItems = [[],[6],[5],[6],[3],[],[4],[]]
Output: []
Explanation: This is the same as example 1 except that 4 needs to be before 6 in the sorted list.
*/

using System;
using System.Text;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.SortItemsbyGroupsRespectingDependencies
{
    public class Solution
    {
        public static int[] SortItems(int n, int m, int[] group, IList<IList<int>> beforeItems)
        {
            Dictionary<int, List<int>> groupItems = new Dictionary<int, List<int>>();
            int groupIdCounter = m;
            for (int i = 0; i < n; i++)
            {
                if (group[i] == -1)
                {
                    group[i] = groupIdCounter;
                    groupIdCounter++;
                }

                if (!groupItems.ContainsKey(group[i]))
                {
                    groupItems[group[i]] = new List<int>();
                }
                groupItems[group[i]].Add(i);
            }

            Dictionary<int, List<int>> itemGraph = new Dictionary<int, List<int>>();
            Dictionary<int, int> itemIndegree = new Dictionary<int, int>();

            for (int v = 0; v < n; v++)
            {
                foreach (int u in beforeItems[v])
                {
                    if (group[u] == group[v])
                    {
                        if (!itemGraph.ContainsKey(u))
                        {
                            itemGraph[u] = new List<int>();
                        }
                        itemGraph[u].Add(v);
                        if (!itemIndegree.ContainsKey(v))
                        {
                            itemIndegree[v] = 0;
                        }
                        itemIndegree[v]++;
                    }
                }
            }

            Dictionary<int, List<int>> sortedGroupItems = new Dictionary<int, List<int>>();

            foreach (int groupIdKey in groupItems.Keys)
            {
                List<int> sortedItems = TopoSort(groupItems[groupIdKey], itemGraph, itemIndegree);

                if (sortedItems.Count != groupItems[groupIdKey].Count)
                {
                    return new int[] { };
                }

                sortedGroupItems[groupIdKey] = sortedItems;
            }

            Dictionary<int, List<int>> groupGraph = new Dictionary<int, List<int>>();
            Dictionary<int, int> groupIndegree = new Dictionary<int, int>();

            for (int v = 0; v < n; v++)
            {
                foreach (int u in beforeItems[v])
                {
                    if (group[u] != group[v])
                    {
                        if (!groupGraph.ContainsKey(group[u]))
                        {
                            groupGraph[group[u]] = new List<int>();
                        }
                        groupGraph[group[u]].Add(group[v]);
                        if (!groupIndegree.ContainsKey(group[v]))
                        {
                            groupIndegree[group[v]] = 0;
                        }
                        groupIndegree[group[v]]++;
                    }
                }
            }

            HashSet<int> groups = new HashSet<int>(group);

            List<int> sortedGroups = TopoSort(groups, groupGraph, groupIndegree);

            if (groups.Count != sortedGroups.Count)
            {
                return new int[] { };
            }

            List<int> ans = new List<int>();

            foreach (int groupId in sortedGroups)
            {
                ans.AddRange(sortedGroupItems[groupId]);
            }

            return ans.ToArray();
        }

        private static List<int> TopoSort(IEnumerable<int> nodes, Dictionary<int, List<int>> graph, Dictionary<int, int> inDegree)
        {
            Queue<int> queue = new Queue<int>(nodes.Where(node => !inDegree.ContainsKey(node)));

            List<int> ans = new List<int>();

            while (queue.Count > 0)
            {
                int curNode = queue.Dequeue();
                ans.Add(curNode);

                if (graph.ContainsKey(curNode))
                {
                    foreach (int neighbor in graph[curNode])
                    {
                        inDegree[neighbor]--;
                        if (inDegree[neighbor] == 0)
                        {
                            queue.Enqueue(neighbor);
                        }
                    }
                }
            }

            return ans;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            int n1 = 8;
            int m1 = 2;
            int[] group1 = { -1, -1, 1, 0, 0, 1, 0, -1 };
            IList<IList<int>> beforeItems1 = new List<IList<int>>
            {
                new List<int>(),
                new List<int> { 6 },
                new List<int> { 5 },
                new List<int> { 6 },
                new List<int> { 3, 6 },
                new List<int>(),
                new List<int>(),
                new List<int>()
            };
            int[] result1 = {0, 5, 2, 6, 3, 4, 7, 1};

            int n2 = 8;
            int m2 = 2;
            int[] group2 = { -1, -1, 1, 0, 0, 1, 0, -1 };
            IList<IList<int>> beforeItems2 = new List<IList<int>>
            {
                new List<int>(),
                new List<int> { 6 },
                new List<int> { 5 },
                new List<int> { 6 },
                new List<int> { 3 },
                new List<int>(),
                new List<int> { 4 },
                new List<int>()
            };
            int[] result2 = {};

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int[]>(Solution.SortItems(n1, m1, group1, beforeItems1), result1),
                ResultTester.CheckResult<int[]>(Solution.SortItems(n2, m2, group2, beforeItems2), result2),
            };

            return results;
        }
    }
}