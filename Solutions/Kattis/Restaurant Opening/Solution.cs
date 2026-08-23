// Restaurant Opening
namespace CompetitiveProgramming.Kattis.RestaurantOpening;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Linq;

class Program
{
    static int n, m;
    static int[][] a = Array.Empty<int[]>();

    static int Getmn(int mi, int mj)
    {
        int ret = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                ret += a[i][j] * (Math.Abs(i - mi) + Math.Abs(j - mj));
            }
        }
        return ret;
    }

    static void Main()
    {
        string[] nm = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        n = int.Parse(nm[0]);
        m = int.Parse(nm[1]);

        a = new int[n][];
        for (int i = 0; i < n; i++)
        {
            a[i] = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                      .Select(int.Parse)
                                      .ToArray();
        }

        int ans = Getmn(0, 0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                ans = Math.Min(ans, Getmn(i, j));
            }
        }

        Console.WriteLine(ans);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Restaurant Opening");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}