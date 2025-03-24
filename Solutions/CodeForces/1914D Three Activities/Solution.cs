// Three Activities
namespace CompetitiveProgramming.CodeForces.ThreeActivities;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            List<List<Tuple<long, int>>> v = new List<List<Tuple<long, int>>>();
            
            for (int i = 0; i < 3; i++)
            {
                List<Tuple<long, int>> row = new List<Tuple<long, int>>();
                long[] values = Array.ConvertAll(Console.ReadLine()!.Split(), long.Parse);
                for (int j = 0; j < n; j++)
                {
                    row.Add(Tuple.Create(values[j], j));
                }
                v.Add(row);
            }

            for (int i = 0; i < 3; i++)
            {
                v[i] = v[i].OrderByDescending(x => x.Item1).ToList();
            }

            long ans = 0;
            for (int i = 0; i < 3 && i < n; i++)
            {
                for (int j = 0; j < 3 && j < n; j++)
                {
                    for (int k = 0; k < 3 && k < n; k++)
                    {
                        if (v[0][i].Item2 != v[1][j].Item2 && 
                            v[1][j].Item2 != v[2][k].Item2 && 
                            v[2][k].Item2 != v[0][i].Item2)
                        {
                            ans = Math.Max(ans, v[0][i].Item1 + v[1][j].Item1 + v[2][k].Item1);
                        }
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Three Activities");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}