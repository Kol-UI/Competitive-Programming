// Evaluate Division

/*
You are given an array of variable pairs equations and an array of real numbers values, where equations[i] = [Ai, Bi] and values[i] represent the equation Ai / Bi = values[i]. Each Ai or Bi is a string that represents a single variable.

You are also given some queries, where queries[j] = [Cj, Dj] represents the jth query where you must find the answer for Cj / Dj = ?.

Return the answers to all queries. If a single answer cannot be determined, return -1.0.

Note: The input is always valid. You may assume that evaluating the queries will not result in division by zero and that there is no contradiction.

 

Example 1:

Input: equations = [["a","b"],["b","c"]], values = [2.0,3.0], queries = [["a","c"],["b","a"],["a","e"],["a","a"],["x","x"]]
Output: [6.00000,0.50000,-1.00000,1.00000,-1.00000]
Explanation: 
Given: a / b = 2.0, b / c = 3.0
queries are: a / c = ?, b / a = ?, a / e = ?, a / a = ?, x / x = ?
return: [6.0, 0.5, -1.0, 1.0, -1.0 ]

Example 2:

Input: equations = [["a","b"],["b","c"],["bc","cd"]], values = [1.5,2.5,5.0], queries = [["a","c"],["c","b"],["bc","cd"],["cd","bc"]]
Output: [3.75000,0.40000,5.00000,0.20000]

Example 3:

Input: equations = [["a","b"]], values = [0.5], queries = [["a","b"],["b","a"],["a","c"],["x","y"]]
Output: [0.50000,2.00000,-1.00000,-1.00000]
*/


using System;
namespace CompetitiveProgramming.LeetCode.EvaluateDivision
{
    public class Solution
    {
        public double[] CalcEquation(IList<IList<string>> eq, double[] vals, IList<IList<string>> q)
        {
            Dictionary<string, Dictionary<string, double>> map = new();
            HashSet<string> visited = new();

            foreach (var (num, den, val) in eq.Zip(vals, (e, v) => (e[0], e[1], v)))
            {
                if (!map.ContainsKey(num)) map[num] = new();
                if (!map.ContainsKey(den)) map[den] = new();

                map[num][den] = 1 / val;
                map[den][num] = val;
            }

            return q.Select(s => FindResult(s[1], s[0])).ToArray();

            double FindResult(string s, string t)
            {
                if (!map.ContainsKey(s)) return -1;
                if (s == t) return 1;
                
                double cur = -1;
                visited.Add(s);
                
                foreach (var k in map[s].Keys)
                {
                    if (visited.Contains(k)) continue;
                    cur = FindResult(k, t);
                    if (cur != -1)
                    {
                        cur *= map[s][k];
                        break;
                    }
                }

                visited.Remove(s);
                return cur;
            }
        }
    }
}