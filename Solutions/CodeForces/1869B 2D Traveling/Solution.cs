// 2D Traveling
namespace CompetitiveProgramming.CodeForces.TwoDTraveling;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

public class Solution
{
    static long Dist(long x1, long y1, long x2, long y2)
    {
        return Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
    }
    
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            var firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = firstLine[0];
            int k = firstLine[1];
            int a = firstLine[2];
            int b = firstLine[3];
            
            (long, long)[] v = new (long, long)[n];
            for(int p = 0; p < n; p++)
            {
                var coords = Console.ReadLine().Split().Select(long.Parse).ToArray();
                v[p] = (coords[0], coords[1]);
            }
            
            a--;
            b--;
            
            long direct = Dist(v[a].Item1, v[a].Item2, v[b].Item1, v[b].Item2);
            
            if(k == 0)
            {
                Console.WriteLine(direct);
                continue;
            }
            
            long minStart = long.MaxValue;
            long minDest = long.MaxValue;
            
            for(int p = 0; p < k; p++)
            {
                minStart = Math.Min(minStart, Dist(v[a].Item1, v[a].Item2, v[p].Item1, v[p].Item2));
                minDest = Math.Min(minDest, Dist(v[b].Item1, v[b].Item2, v[p].Item1, v[p].Item2));
            }
            
            long result = Math.Min(direct, minStart + minDest);
            Console.WriteLine(result);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("2D Traveling");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}