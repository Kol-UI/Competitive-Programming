// Come Together
namespace CompetitiveProgramming.CodeForces.ComeTogether;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] input1 = Console.ReadLine().Split();
            long xa = long.Parse(input1[0]);
            long ya = long.Parse(input1[1]);
            string[] input2 = Console.ReadLine().Split();
            long xb = long.Parse(input2[0]);
            long yb = long.Parse(input2[1]);
            string[] input3 = Console.ReadLine().Split();
            long xc = long.Parse(input3[0]);
            long yc = long.Parse(input3[1]);

            long cnt = 1;
            if (xa < xb && xa < xc) cnt += Math.Min(xb, xc) - xa;
            else if (xa > xb && xa > xc) cnt += xa - Math.Max(xb, xc);

            if (ya < yb && ya < yc) cnt += Math.Min(yb, yc) - ya;
            else if (ya > yb && ya > yc) cnt += ya - Math.Max(yb, yc);

            Console.WriteLine(cnt);
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
        StyleHelper.Title("Come Together");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}