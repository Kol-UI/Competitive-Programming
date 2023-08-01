using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.CheapestFlightsWithinKStops
{
    public class Solution
    {
        //There are n cities connected by some number of flights. You are given an array flights where flights[i] = [fromi, toi, pricei] indicates that there is a flight from city fromi to city toi with cost pricei.
        //You are also given three integers src, dst, and k, return the cheapest price from src to dst with at most k stops. If there is no such route, return -1.
        public static int FindCheapestPrice(int n, int[][] flights, int src, int dst, int k)
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

    public class Test
    {
        public static bool[] TestCheapestFlightsWithinKStops()
        {
            int n1 = 4;
            int[][] flights1 = new int[][]
            {
                new int[] {0, 1, 100},
                new int[] {1, 2, 100},
                new int[] {2, 0, 100},
                new int[] {1, 3, 600},
                new int[] {2, 3, 200},
            };
            int src1 = 0;
            int dst1 = 3;
            int k1 = 1;

            int output1 = Solution.FindCheapestPrice(n1, flights1, src1, dst1, k1);
            int expected1 = 700;

            int n2 = 3;
            int[][] flights2 = new int[][]
            {
                new int[] {0, 1, 100},
                new int[] {1, 2, 100},
                new int[] {0, 2, 500},
            };
            int src2 = 0;
            int dst2 = 2;
            int k2 = 1;

            int output2 = Solution.FindCheapestPrice(n2, flights2, src2, dst2, k2);
            int expected2 = 200;

            int n3 = 3;
            int[][] flights3 = new int[][]
            {
                new int[] {0, 1, 100},
                new int[] {1, 2, 100},
                new int[] {0, 2, 500},
            };
            int src3 = 0;
            int dst3 = 2;
            int k3 = 0;

            int output3 = Solution.FindCheapestPrice(n3, flights3, src3, dst3, k3);
            int expected3 = 500;

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(output1, expected1),
                ResultTester.CheckResult<int>(output2, expected2),
                ResultTester.CheckResult<int>(output3, expected3)
            };
            return results;
        }
    }
}

