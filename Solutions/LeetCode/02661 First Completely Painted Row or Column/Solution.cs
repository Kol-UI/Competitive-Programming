// First Completely Painted Row or Column

namespace CompetitiveProgramming.CodeForces.FirstCompletelyPaintedRoworColumn;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int FirstCompleteIndex(int[] arr, int[][] mat)
    {
        var dict = new Dictionary<int, Tuple<int, int>>();

        for (var i = 0; i < mat.Length; ++i)
        {
            for (var j = 0; j < mat[i].Length; ++j)
            {
                dict.Add(mat[i][j], new Tuple<int, int>(i, j));
            }
        }

        if (dict.Count == 0)
        {
            return -1;
        }

        var rows = new int[mat.Length];
        var cols = new int[mat[0].Length];

        for (var i = 0; i < arr.Length; ++i)
        {
            var item = dict[arr[i]];

            rows[item.Item1]++;
            cols[item.Item2]++;
            if (rows[item.Item1] == mat[0].Length || cols[item.Item2] == mat.Length)
            {
                return i;
            }
        }

        return -1;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("First Completely Painted Row or Column");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}