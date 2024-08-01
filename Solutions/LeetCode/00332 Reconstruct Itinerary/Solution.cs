// Reconstruct Itinerary

/*
You are given a list of airline tickets where tickets[i] = [fromi, toi] represent the departure and the arrival airports of one flight. Reconstruct the itinerary in order and return it.

All of the tickets belong to a man who departs from "JFK", thus, the itinerary must begin with "JFK". If there are multiple valid itineraries, you should return the itinerary that has the smallest lexical order when read as a single string.

For example, the itinerary ["JFK", "LGA"] has a smaller lexical order than ["JFK", "LGB"].
You may assume all tickets form at least one valid itinerary. You must use all the tickets once and only once.

 

Example 1:


Input: tickets = [["MUC","LHR"],["JFK","MUC"],["SFO","SJC"],["LHR","SFO"]]
Output: ["JFK","MUC","LHR","SFO","SJC"]


Example 2:


Input: tickets = [["JFK","SFO"],["JFK","ATL"],["SFO","ATL"],["ATL","JFK"],["ATL","SFO"]]
Output: ["JFK","ATL","JFK","SFO","ATL","SFO"]
Explanation: Another possible reconstruction is ["JFK","SFO","ATL","JFK","ATL","SFO"] but it is larger in lexical order.
*/


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.LeetCode.ReconstructItinerary
{
    public class Solution 
    {
        static int flights = 0;
        static Dictionary<string,List<string>> adjList = new Dictionary<string,List<string>>();
        static Dictionary<string,int[]> visitedBits = new Dictionary<string,int[]>();
        
        public static IList<string> FindItinerary(IList<IList<string>> tickets) 
        {
            foreach(var tkt in tickets)
            {
                adjList.TryAdd(tkt[0],new List<string>());
                adjList[tkt[0]].Add(tkt[1]);
            }
            
            foreach(var kv in adjList)
            {
                kv.Value.Sort((x,y)=>x.CompareTo(y));
                visitedBits.Add(kv.Key,new int[kv.Value.Count]);
            }
            
            flights = tickets.Count+1;
            
            IList<string> path = new List<string>(){"JFK"};
            Backtrack("JFK", path);
            return path;
            
        }
        
        private static bool Backtrack(string city, IList<string> path)
        {
            if(path.Count == flights)
                return true;
            
            if(!adjList.ContainsKey(city))
                return false;
            
            int[] vBits = visitedBits[city];
            List<string> cities = adjList[city];
            
            for(int i = 0; i < cities.Count; i++)
            {
                
                if(vBits[i] == 0)
                {
                    vBits[i] = 1;
                    path.Add(cities[i]);
                    if(Backtrack(cities[i],path))
                        return true;
                    vBits[i] = 0;
                    path.RemoveAt(path.Count - 1);
                }
            }
            
            return false;
        }
    }


    public class Test
    {
        public static bool[] TestCases()
        {
            IList<IList<string>> tickets1 = new List<IList<string>>
            {
                new List<string> { "MUC", "LHR" },
                new List<string> { "JFK", "MUC" },
                new List<string> { "SFO", "SJC" },
                new List<string> { "LHR", "SFO" }
            };

            IList<IList<string>> tickets2 = new List<IList<string>>
            {
                new List<string> { "JFK", "SFO" },
                new List<string> { "JFK", "ATL" },
                new List<string> { "SFO", "ATL" },
                new List<string> { "ATL", "JFK" },
                new List<string> { "ATL", "SFO" }
            };

            IList<string> airportCodes1 = new List<string>
            {
                "JFK", "MUC", "LHR", "SFO", "SJC"
            };

            IList<string> airportCodes2 = new List<string>
            {
                "JFK", "ATL", "JFK", "SFO", "ATL", "SFO"
            };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<IList<string>>(Solution.FindItinerary(tickets1), airportCodes1),
                ResultTester.CheckResult<IList<string>>(Solution.FindItinerary(tickets2), airportCodes2),
            };
            return results;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Reconstruct Itinerary");
            ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
        }
    }
}