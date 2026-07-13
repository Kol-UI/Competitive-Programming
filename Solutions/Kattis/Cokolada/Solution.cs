// Cokolada
namespace CompetitiveProgramming.Kattis.Cokolada;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8629
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());

        int i = 0;
        int? lo = null;
        int? hi = null;

        while ((1 << i) < k)
        {
            if ((k & (1 << i)) != 0)
            {
                if (lo == null)
                    lo = i;
                hi = i;
            }
            i++;
        }

        int ans = 0;
        if ((1 << i) == k)
            ans = 0;
        else
            ans = hi.Value - lo.Value + 1;

        Console.WriteLine($"{1 << i} {ans}");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8629
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Cokolada");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}