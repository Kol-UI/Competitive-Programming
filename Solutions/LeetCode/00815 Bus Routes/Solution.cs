// Bus Routes

/*
You are given an array routes representing bus routes where routes[i] is a bus route that the ith bus repeats forever.

For example, if routes[0] = [1, 5, 7], this means that the 0th bus travels in the sequence 1 -> 5 -> 7 -> 1 -> 5 -> 7 -> 1 -> ... forever.
You will start at the bus stop source (You are not on any bus initially), and you want to go to the bus stop target. You can travel between bus stops by buses only.

Return the least number of buses you must take to travel from source to target. Return -1 if it is not possible.

 

Example 1:

Input: routes = [[1,2,7],[3,6,7]], source = 1, target = 6
Output: 2
Explanation: The best strategy is take the first bus to the bus stop 7, then take the second bus to the bus stop 6.
Example 2:

Input: routes = [[7,12],[4,5,15],[6],[15,19],[9,12,13]], source = 15, target = 12
Output: -1
*/

using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.BusRoutes
{
    public class Solution
    {
        public static int NumBusesToDestination(int[][] routes, int source, int target)
        {
            Dictionary<int,List<int>> routeDict = new();
            Queue<(int stop, int routeLength)> queue = new();
            for(int i = 0; i < routes.Length; i++)
            {
            for(int j = 0; j <routes[i].Length; j++)
            {
                int stop = routes[i][j];
                if(!routeDict.ContainsKey(stop))
                {
                    routeDict.Add(stop, new());
                }
                routeDict[stop].Add(i);
            }
            }

            HashSet<int> visitedBuses = new();
            HashSet<int> visitedStops = new();
            queue.Enqueue((source, 0));

            while(queue.Any())
            {
                var item = queue.Dequeue();
                if(item.stop == target)
                {
                    return item.routeLength;
                }
                else
                {
                foreach (int bus in routeDict.TryGetValue(item.stop, out var buses) ? buses : new List<int>())
                {
                    if(!visitedBuses.Contains(bus))
                    {
                        visitedBuses.Add(bus);
                        for(int i = 0; i < routes[bus].Length; i++)
                        {
                            if(!visitedStops.Contains(routes[bus][i]))
                            {
                                visitedStops.Add(routes[bus][i]);
                                queue.Enqueue((routes[bus][i], item.routeLength+1));
                            }
                        }
                    }
                }
                }
            }
            return -1;
        }
    }

    public class Test
    {
        public static bool[] TestBusRoutes()
        {
            int[][] routes1 = new int[][]
            {
                new int[] { 1, 2, 7 },
                new int[] { 3, 6, 7 },
                new int[] { 23, 30, 34, 60 }
            };
            int source1 = 1;
            int target1 = 6;
            int[][] routes2 = new int[][]
            {
                new int[] { 7,12 },
                new int[] { 4,5,15 },
                new int[] { 6 },
                new int[] { 15,19 },
                new int[] { 9,12,13 }
            };
            int source2 = 1;
            int target2 = 6;
            int result1 = Solution.NumBusesToDestination(routes1, source1, target1);
            int result2 = Solution.NumBusesToDestination(routes2, source2, target2);
            bool[] results = new bool[]
            {
                ResultTester.CheckResult<int>(result1, 2),
                ResultTester.CheckResult<int>(result2, -1)
            };

            return results;
        }
    }
}