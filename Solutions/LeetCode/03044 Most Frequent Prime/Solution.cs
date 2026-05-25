// Most Frequent Prime
namespace CompetitiveProgramming.LeetCode.MostFrequentPrime;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

public class Solution
{
    public int MostFrequentPrime(int[][] mat)
    {
        var dic = new Dictionary<int, int>();
        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[i].Length; j++)
            {
                AddMap(i, j, dic, mat);
            }
        }
        var maxVal = 0;
        var result = -1;
        foreach (var item in dic)
        {
            if (maxVal <= item.Value)
            {
                if (maxVal < item.Value)
                {
                    maxVal = item.Value;
                    result = item.Key;
                }
                else
                {
                    result = Math.Max(result, item.Key);
                }
            }
        }
        return result;
    }

    private void AddMap(int row, int col, Dictionary<int, int> dic, int[][] mat)
    {
        for (int r = -1; r <= 1; r++)
        {
            for (int c = -1; c <= 1; c++)
            {
                if (r == 0 && c == 0) continue;
                var currRow = row;
                var currCol = col;
                var n = mat[row][col];
                while (IsInside(currRow + r, currCol + c, mat))
                {
                    currRow += r;
                    currCol += c;
                    n *= 10;
                    n += mat[currRow][currCol];
                    if (!dic.ContainsKey(n))
                    {
                        if (IsPrime(n)) dic.Add(n, 1);
                    }
                    else
                    {
                        dic[n]++;
                    }
                }
            }
        }
    }

    private bool IsPrime(int n)
    {
        if (n < 10 || n % 2 == 0) return false;
        for (int i = 3; i <= (int)Math.Sqrt(n); i += 2)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    private bool IsInside(int row, int col, int[][] mat)
    {
        return 0 <= row && row < mat.Length && 0 <= col && col < mat[row].Length;
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Most Frequent Prime");
        ResultTester.SpecialTestCase(ProblemOrigin.LeetCode, ProblemCategory.MediumLC);
    }
}