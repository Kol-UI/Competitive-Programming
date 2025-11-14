// Increment Submatrices by One
namespace CompetitiveProgramming.LeetCode.IncrementSubmatricesbyOne;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int[][] RangeAddQueries(int n, int[][] queries)
    {
        var arr = new int[n][];
        for (var i = 0; i < n; i++)
        {
            arr[i] = new int[n];
        }

        for (var i = 0; i < queries.Length; i++)
        {
            var row1 = queries[i][0];
            var row2 = queries[i][2];
            var col1 = queries[i][1];
            var col2 = queries[i][3];
            for (var j = row1; j <= row2; j++)
            {
                arr[j][col1]++;
                if (col2 + 1 < n) arr[j][col2+1]--;
            }
        }

        for (var i = 0; i < n; i++)
        {
            for (var j = 1; j < n; j++)
            {
                arr[i][j] += arr[i][j-1];
            }
        }

        return arr;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Increment Submatrices by One");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}