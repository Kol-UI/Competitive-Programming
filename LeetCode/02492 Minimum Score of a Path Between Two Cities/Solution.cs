using System;
namespace CompetitiveProgramming.LeetCode.MinimumScoreofaPathBetweenTwoCities
{
    /*
        You are given a positive integer n representing n cities numbered from 1 to n. You are also given a 2D array roads where roads[i] = [ai, bi, distancei] indicates that there is a bidirectional road between cities ai and bi with a distance equal to distancei. The cities graph is not necessarily connected.

        The score of a path between two cities is defined as the minimum distance of a road in this path.

        Return the minimum possible score of a path between cities 1 and n.

        Note:

        A path is a sequence of roads between two cities.
        It is allowed for a path to contain the same road multiple times, and you can visit cities 1 and n multiple times along the path.
        The test cases are generated such that there is at least one path between 1 and n.
        

        Example 1:
        Input: n = 4, roads = [[1,2,9],[2,3,6],[2,4,5],[1,4,7]]
        Output: 6
        Explanation: The path from city 1 to 4 with the minimum score is: 1 -> 2 -> 4. The score of this path is min(9,5) = 5.
        It can be shown that no other path has less score.
        
        Example 2:
        Input: n = 4, roads = [[1,2,2],[1,3,4],[3,4,7]]
        Output: 2
        Explanation: The path from city 1 to 4 with the minimum score is: 1 -> 2 -> 1 -> 3 -> 4. The score of this path is min(2,2,4,7) = 2.
    */

    public class Solution
    {
        public static int MinScore(int n, int[][] roads)
        {
            
            var adj = new Dictionary<int, List<int[]>>();
            int ans = int.MaxValue;

            foreach(var road in roads)
            {
                adj.TryAdd(road[0], new List<int[]>());
                adj[road[0]].Add(new int[]{road[1], road[2]});

                adj.TryAdd(road[1], new List<int[]>());
                adj[road[1]].Add(new int[]{road[0], road[2]});
            }

            var visited = new int[n+1];
            var q = new Queue<int>();
            q.Enqueue(1);

            void BFS()
            {
                while(q.Count > 0)
                {
                    var curr = q.Dequeue();
                    if(visited[curr]==1)
                    {
                        continue;
                    }
                    foreach(var edge in adj[curr])
                    {
                        if(visited[curr] != 1)
                        {
                            q.Enqueue(edge[0]);
                        }
                        ans = Math.Min(ans, edge[1]);
                    }
                    visited[curr] = 1;
                }
            }

            BFS();

            return ans;
        }
    }
}