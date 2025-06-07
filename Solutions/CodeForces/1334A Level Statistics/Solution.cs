// Level Statistics
namespace CompetitiveProgramming.CodeForces.LevelStatistics;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            List<Tuple<int, int>> v = new List<Tuple<int, int>>();
            for (int i = 0; i < n; i++)
            {
                int[] xy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                v.Add(new Tuple<int, int>(xy[0], xy[1]));
            }

            int a = 0, b = 0;
            bool ok = true;
            for (int i = 0; i < n; i++)
            {
                if (i > 0)
                {
                    if (v[i].Item1 < v[i - 1].Item1)
                        ok = false;
                    if (v[i].Item2 < v[i - 1].Item2)
                        ok = false;
                    if (v[i].Item1 - v[i - 1].Item1 < v[i].Item2 - v[i - 1].Item2)
                        ok = false;
                }
                a += v[i].Item1;
                b += v[i].Item2;
                if (a < b)
                    ok = false;
            }
            Console.WriteLine(ok ? "YES" : "NO");
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
	public override void GetResult()
	{
        StyleHelper.Space();
        StyleHelper.Title("Level Statistics");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
	}
}