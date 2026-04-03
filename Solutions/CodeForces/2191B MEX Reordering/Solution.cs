// MEX Reordering
namespace CompetitiveProgramming.CodeForces.MEXReordering;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
/*
public class Main()
{
    if (long.TryParse(Console.ReadLine(), out long t))
    {
        while (t-- > 0)
        {
            if (!long.TryParse(Console.ReadLine(), out long n)) continue;

            string[] inputs = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();
            long z = 0;
            bool a = false;

            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(inputs[p]);
                if (x == 0) z++;
                else if (x == 1) a = true;
            }

            Console.WriteLine((z == 1) || (z > 1 && a) ? "YES" : "NO");
        }
    }
}*/

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("MEX Reordering");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}