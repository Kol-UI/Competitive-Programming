// NIT Destroys the Universe
namespace CompetitiveProgramming.CodeForces.NITDestroystheUniverse;
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
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            long cnt = 0;
            bool cur = false;
            string[] input = Console.ReadLine().Split();
            for (long i = 0; i < n; i++)
            {
                long x = long.Parse(input[i]);
                if (x != 0) cur = true;
                else if (cur) { cnt++; cur = false; }
            }
            cnt += cur ? 1 : 0;
            cnt = cnt < 2 ? cnt : 2;
            Console.WriteLine(cnt);
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
        StyleHelper.Title("NIT Destroys the Universe");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}