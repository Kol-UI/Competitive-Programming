// Ski Resort
namespace CompetitiveProgramming.CodeForces.SkiResort;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long[] nkq = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long n = nkq[0], k = nkq[1], q = nkq[2];
            long cnt = 0, res = 0;
            
            long[] temps = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            foreach (long x in temps)
            {
                if (x <= q) cnt++;
                else cnt = 0;
                res += cnt >= k ? cnt - k + 1 : 0;
            }
            
            Console.WriteLine(res);
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
        StyleHelper.Title("Ski Resort");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}