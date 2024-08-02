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
using CompetitiveProgramming.TestDrivenDevelopment;

namespace CompetitiveProgramming.LeetCode.EvaluateDivision
{
    public class Solution
    {
        public static double[] CalcEquation(IList<IList<string>> eq, double[] vals, IList<IList<string>> q)
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

    public class Test
    {
        public static bool[] TestEvaluateDivision()
        {
            IList<IList<string>> equations1 = new List<IList<string>>
            {
                new List<string> { "a", "b" },
                new List<string> { "b", "c" }
            };

            double[] values1 = new double[] { 2.0, 3.0 };

            IList<IList<string>> queries1 = new List<IList<string>>
            {
                new List<string> { "a", "c" },
                new List<string> { "b", "a" },
                new List<string> { "a", "e" },
                new List<string> { "a", "a" },
                new List<string> { "x", "x" }
            };

            double[] output1 = new double[] { 6.00000, 0.50000, -1.00000, 1.00000, -1.00000 };

            IList<IList<string>> equations2 = new List<IList<string>>
            {
                new List<string> { "a", "b" },
                new List<string> { "b", "c" },
                new List<string> { "bc", "cd" }
            };

            double[] values2 = new double[] { 1.5, 2.5, 5.0 };

            IList<IList<string>> queries2 = new List<IList<string>>
            {
                new List<string> { "a", "c" },
                new List<string> { "c", "b" },
                new List<string> { "bc", "cd" },
                new List<string> { "cd", "bc" }
            };

            double[] output2 = new double[] { 3.75000, 0.40000, 5.00000, 0.20000 };

            IList<IList<string>> equations3 = new List<IList<string>>
            {
                new List<string> { "a", "b" }
            };

            double[] values3 = new double[] { 0.5 };

            IList<IList<string>> queries3 = new List<IList<string>>
            {
                new List<string> { "a", "b" },
                new List<string> { "b", "a" },
                new List<string> { "a", "c" },
                new List<string> { "x", "y" }
            };

            double[] output3 = new double[] { 0.50000, 2.00000, -1.00000, -1.00000 };

            bool[] results = new bool[]
            {
                ResultTester.CheckResult<double[]>(Solution.CalcEquation(equations1, values1, queries1), output1),
                ResultTester.CheckResult<double[]>(Solution.CalcEquation(equations2, values2, queries2), output2),
                ResultTester.CheckResult<double[]>(Solution.CalcEquation(equations3, values3, queries3), output3)
            };
            return results;
        }
    }

    public class TestSolution : Models.BaseSolution
    {
        public override void GetResult()
        {
            Helpers.StyleHelper.Space();
            Helpers.StyleHelper.Title("Evaluate Division");
            ResultTester.CheckCurrentSolution(ProblemOrigin.LeetCode, ProblemCategory.MediumLC, Test.TestEvaluateDivision());
        }
    }
}