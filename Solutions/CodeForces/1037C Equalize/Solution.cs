// Equalize
namespace CompetitiveProgramming.CodeForces.Equalize1037C;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        string a = Console.ReadLine();
        string b = Console.ReadLine();

        char[] arr = a.ToCharArray();
        long cnt = 0;

        for (long p = 0; p < n; p++)
        {
            if (arr[p] == b[(int)p]) continue;
            else if (arr[p] != b[(int)p] && p + 1 < n && arr[p + 1] != b[(int)(p + 1)] && arr[p] != arr[p + 1])
            {
                cnt++;
                arr[p] = b[(int)p];
                arr[p + 1] = b[(int)(p + 1)];
            }
            else
            {
                cnt++;
                arr[p] = b[(int)p];
            }
        }

        Console.WriteLine(cnt);
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Equalize");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}