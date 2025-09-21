// Three Friends
namespace CompetitiveProgramming.CodeForces.ThreeFriends;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        long q = long.Parse(Console.ReadLine());
        while (q-- > 0)
        {
            long[] x = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            Array.Sort(x);
            if (x[0] < x[2]) x[0]++;
            if (x[1] < x[2]) x[1]++;
            if (x[2] > x[0]) x[2]--;
            long ans = 2 * (x[2] - x[0]);
            Console.WriteLine(ans);
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
        StyleHelper.Title("Three Friends");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}