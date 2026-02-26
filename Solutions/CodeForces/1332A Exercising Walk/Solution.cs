// Exercising Walk
namespace CompetitiveProgramming.CodeForces.ExercisingWalk;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            var moves = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long a = moves[0];
            long b = moves[1];
            long c = moves[2];
            long d = moves[3];
            
            var bounds = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long x = bounds[0];
            long y = bounds[1];
            long x1 = bounds[2];
            long y1 = bounds[3];
            long x2 = bounds[4];
            long y2 = bounds[5];
            
            bool result = true;
            x += b - a;
            if(x < x1 || x > x2) result = false;
            if(a == b && x1 == x2 && a > 0) result = false;
            
            y += d - c;
            if(y < y1 || y > y2) result = false;
            if(c == d && y1 == y2 && c > 0) result = false;
            
            Console.WriteLine(result ? "Yes" : "No");
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
        StyleHelper.Title("Exercising Walk");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}