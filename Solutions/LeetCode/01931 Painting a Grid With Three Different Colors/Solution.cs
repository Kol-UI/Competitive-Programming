// Painting a Grid With Three Different Colors
namespace CompetitiveProgramming.LeetCode.PaintingaGridWithThreeDifferentColors;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

public class Solution
{
    private const int MOD = 1000000007;

    public int ColorTheGrid(int m, int n)
    {
        var validCols = GenerateValidColumns(m);
        var transitions = new Dictionary<string, List<string>>();

        foreach (var col1 in validCols)
        {
            transitions[col1] = new List<string>();
            foreach (var col2 in validCols)
            {
                if (IsValidTransition(col1, col2))
                {
                    transitions[col1].Add(col2);
                }
            }
        }

        var memo = new Dictionary<(int, string), int>();
        
        int Dfs(int i, string prevCol)
        {
            if (i == n) return 1;
            if (memo.ContainsKey((i, prevCol))) return memo[(i, prevCol)];

            long ways = 0;
            foreach (var nextCol in transitions[prevCol])
            {
                ways = (ways + Dfs(i + 1, nextCol)) % MOD;
            }

            memo[(i, prevCol)] = (int)ways;
            return (int)ways;
        }

        long result = 0;
        foreach (var col in validCols)
        {
            result = (result + Dfs(1, col)) % MOD;
        }

        return (int)result;
    }

    private List<string> GenerateValidColumns(int m)
    {
        var res = new List<string>();
        void Backtrack(List<int> col)
        {
            if (col.Count == m) {
                res.Add(string.Join("", col));
                return;
            }
            for (int color = 0; color < 3; color++)
            {
                if (col.Count == 0 || col[col.Count - 1] != color)
                {
                    col.Add(color);
                    Backtrack(col);
                    col.RemoveAt(col.Count - 1);
                }
            }
        }
        Backtrack(new List<int>());
        return res;
    }

    private bool IsValidTransition(string col1, string col2)
    {
        for (int i = 0; i < col1.Length; i++)
        {
            if (col1[i] == col2[i]) return false;
        }
        return true;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Painting a Grid With Three Different Colors");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.HardLC);
    }
}