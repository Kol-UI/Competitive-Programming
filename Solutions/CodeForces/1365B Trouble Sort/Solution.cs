// Trouble Sort
namespace CompetitiveProgramming.CodeForces.TroubleSort;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Solution
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());

            bool sorted = true;
            long prev = 0;
            string[] vals = Console.ReadLine().Split();
            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(vals[p]);
                if (p > 0 && x < prev) sorted = false;
                prev = x;
            }

            bool a = false, z = false;
            string[] types = Console.ReadLine().Split();
            for (long p = 0; p < n; p++)
            {
                int x = int.Parse(types[p]);
                a |= (x == 1);
                z |= (x == 0);
            }

            bool res = sorted || (a && z);
            Console.WriteLine(res ? "Yes" : "No");
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
        StyleHelper.Title("Trouble Sort");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}