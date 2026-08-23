// Vitaliy and Pie
namespace CompetitiveProgramming.CodeForces.VitaliyandPie;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        const int N = 26;
        long n = long.Parse(Console.ReadLine());
        string s = Console.ReadLine();
        int[] keyBag = new int[N];
        long count = 0;

        for (int p = 0; p < 2 * n - 2; p++)
        {
            if (p % 2 == 1)
            {
                if (keyBag[s[p] - 'A'] > 0)
                {
                    keyBag[s[p] - 'A']--;
                }
                else
                {
                    count++;
                }
            }
            else
            {
                keyBag[s[p] - 'a']++;
            }
        }

        Console.WriteLine(count);
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
        StyleHelper.Title("Vitaliy and Pie");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}
