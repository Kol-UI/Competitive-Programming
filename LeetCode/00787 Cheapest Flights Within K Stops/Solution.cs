using System;

namespace CompetitiveProgramming.LeetCode.CheapestFlightsWithinKStops
{
    public class Solution
    {
        //There are n cities connected by some number of flights. You are given an array flights where flights[i] = [fromi, toi, pricei] indicates that there is a flight from city fromi to city toi with cost pricei.
        //You are also given three integers src, dst, and k, return the cheapest price from src to dst with at most k stops. If there is no such route, return -1.
        public int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
        {
            int[] dist = new int[n];
            Array.Fill(dist, int.MaxValue);
            dist[src] = 0;
            for (int i = 0; i <= k; i++)
            {
                int[] temp = dist.ToArray();
                foreach (int[] flight in flights)
                {
                    if (dist[flight[0]] != int.MaxValue) 
                    {
                        temp[flight[1]] = Math.Min(temp[flight[1]], dist[flight[0]] + flight[2]);
                    }
                }
                dist = temp;
            }
            return dist[dst] == int.MaxValue ? -1 : dist[dst];
        }
    }
}

