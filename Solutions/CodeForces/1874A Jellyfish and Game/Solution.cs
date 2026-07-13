// Jellyfish and Game
namespace CompetitiveProgramming.CodeForces.JellyfishandGame;
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
            string[] firstLine = Console.ReadLine().Split();
            long n = long.Parse(firstLine[0]);
            long m = long.Parse(firstLine[1]);
            long k = long.Parse(firstLine[2]);

            long amn = 1000000007, amx = 0;
            long bmn = 1000000007, bmx = 0;
            long sa = 0;

            string[] aInput = Console.ReadLine().Split();
            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(aInput[p]);
                sa += x;
                if (x < amn) amn = x;
                if (x > amx) amx = x;
            }

            string[] bInput = Console.ReadLine().Split();
            for (long p = 0; p < m; p++)
            {
                long x = long.Parse(bInput[p]);
                if (x < bmn) bmn = x;
                if (x > bmx) bmx = x;
            }

            if (bmx > amn) sa += (bmx - amn);
            if (k % 2 == 0)
            {
                long minVal = (bmn < amn) ? bmn : amn;
                long maxVal = (bmx > amx) ? bmx : amx;
                sa += (minVal - maxVal);
            }

            Console.WriteLine(sa);
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
        StyleHelper.Title("Jellyfish and Game");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}