using System;
namespace CompetitiveProgramming.LeetCode.NumberofOperationstoMakeNetworkConnected
{
    /*
        There are n computers numbered from 0 to n - 1 connected by ethernet cables connections forming a network
        where connections[i] = [ai, bi] represents a connection between computers ai and bi.
        Any computer can reach any other computer directly or indirectly through the network.
        You are given an initial computer network connections.
        You can extract certain cables between two directly connected computers,
        and place them between any pair of disconnected computers to make them directly connected.
        Return the minimum number of times you need to do this in order to make all the computers connected.
        If it is not possible, return -1.
        

        Example 1:
        Input: n = 4, connections = [[0,1],[0,2],[1,2]]
        Output: 1
        Explanation: Remove cable between computer 1 and 2 and place between computers 1 and 3.
        
        Example 2:
        Input: n = 6, connections = [[0,1],[0,2],[0,3],[1,2],[1,3]]
        Output: 2

        Example 3:
        Input: n = 6, connections = [[0,1],[0,2],[0,3],[1,2]]
        Output: -1
        Explanation: There are not enough cables.
    */

    public class Solution
    {
        public static int MakeConnected(int n, int[][] connections) 
        {
            if (connections.Length < n - 1) return -1;
            int[] parentConnections = Enumerable.Range(0, n).ToArray();

            int cablesNeeded = n;
            
            foreach (var connection in connections)
            {
                int p1 = FindParentConnection(parentConnections, connection[0]);
                int p2 = FindParentConnection(parentConnections, connection[1]);

                if (p1 != p2)
                {
                    parentConnections[p2] = p1;
                    cablesNeeded--;
                }
            }
            return cablesNeeded - 1;
            
            int FindParentConnection(int[] arr, int i)
            {
                while (i != arr[i])
                {
                    arr[i] = arr[arr[i]];
                    i = arr[i];
                }
                return i;
            }
        }
    }
}