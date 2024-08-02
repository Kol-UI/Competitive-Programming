using System;
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.MinimumFuelCosttoReporttotheCapital
{
	public class Solution
    {
        // There is a tree (i.e., a connected, undirected graph with no cycles) structure country network consisting of n cities numbered from 0 to n - 1 and exactly n - 1 roads.
        // The capital city is city 0.
        // You are given a 2D integer array roads where roads[i] = [ai, bi] denotes that there exists a bidirectional road connecting cities ai and bi.
        // There is a meeting for the representatives of each city. The meeting is in the capital city.
        // There is a car in each city.
        // You are given an integer seats that indicates the number of seats in each car.
        // A representative can use the car in their city to travel or change the car and ride with another representative.
        // The cost of traveling between two cities is one liter of fuel.
        // Return the minimum number of liters of fuel to reach the capital city.

        // Example 1:
        // Input: roads = [[0,1],[0,2],[0,3]], seats = 5
        // Output: 3
        // Explanation: 
        // - Representative1 goes directly to the capital with 1 liter of fuel.
        // - Representative2 goes directly to the capital with 1 liter of fuel.
        // - Representative3 goes directly to the capital with 1 liter of fuel.
        // It costs 3 liters of fuel at minimum. 
        // It can be proven that 3 is the minimum number of liters of fuel needed.

        // Example 2:
        // Input: roads = [[3,1],[3,2],[1,0],[0,4],[0,5],[4,6]], seats = 2
        // Output: 7
        // Explanation: 
        // - Representative2 goes directly to city 3 with 1 liter of fuel.
        // - Representative2 and representative3 go together to city 1 with 1 liter of fuel.
        // - Representative2 and representative3 go together to the capital with 1 liter of fuel.
        // - Representative1 goes directly to the capital with 1 liter of fuel.
        // - Representative5 goes directly to the capital with 1 liter of fuel.
        // - Representative6 goes directly to city 4 with 1 liter of fuel.
        // - Representative4 and representative6 go together to the capital with 1 liter of fuel.
        // It costs 7 liters of fuel at minimum. 
        // It can be proven that 7 is the minimum number of liters of fuel needed.

        // Example 3:
        // Input: roads = [], seats = 1
        // Output: 0
        // Explanation: No representatives need to travel to the capital city.

        private static long cost;
        public static long MinimumFuelCost(int[][] roads, int seats)
        {
            if(roads.GetLength(0) == 0)
                return 0;
                
            cost = 0;
            var graph = new Dictionary<int, List<int>>();

            foreach (var road in roads)
            {
                if (!graph.ContainsKey(road[0]))
                    graph[road[0]] = new List<int>();

                if (!graph.ContainsKey(road[1]))
                    graph[road[1]] = new List<int>();

                graph[road[0]].Add(road[1]);
                graph[road[1]].Add(road[0]);
            }

            DFS(graph, 0, 0, seats);
            return cost;
        }

        private static int DFS(Dictionary<int, List<int>> graph, int prev, int city, int seat)
        {
            int rep = 1;
            foreach(var neighbour in graph[city]) {
                if(neighbour != prev)
                    rep += DFS(graph, city, neighbour, seat);
            }

            if(city != 0)
                cost += (rep / seat) + (rep % seat > 0 ? 1 : 0);
            
            return rep;
        }
    }

    public class Test
    {
        public static bool[] TestCases()
        {
            // Case 1
            int[][] roadsCase1_2477 = new int[][]
            {
                new int[] {0, 1},
                new int[] {0, 2},
                new int[] {0, 3}
            };
            int seatsCase1_2477 = 5;
            long Case1_2477_Result = Solution.MinimumFuelCost(roadsCase1_2477, seatsCase1_2477);

            // Case 2
            int[][] roadsCase2_2477 = new int[][]
            {
                new int[] {3, 1},
                new int[] {3, 2},
                new int[] {1, 0},
                new int[] {0, 4},
                new int[] {0, 5},
                new int[] {4, 6}
            };
            int seatsCase2_2477 = 2;
            long Case2_2477_Result = Solution.MinimumFuelCost(roadsCase2_2477, seatsCase2_2477);

            // Case 3
            int[][] roadsCase3_2477 = new int[][] { };
            int seatsCase3_2477 = 1;
            long Case3_2477_Result = Solution.MinimumFuelCost(roadsCase3_2477, seatsCase3_2477);

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<long>(Case1_2477_Result, 3),
                ResultTester.CheckResult<long>(Case2_2477_Result, 7),
                ResultTester.CheckResult<long>(Case3_2477_Result, 0)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Minimum Fuel Cost to Report to the Capital");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestCases());
        }
    }
}