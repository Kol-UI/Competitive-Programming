// Petya and Countryside

namespace CompetitiveProgramming.CodeForces.PetyaandCountryside;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int n = int.Parse(Console.ReadLine()!);
        int[] v = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
        int ans = 0;

        for (int i = 0; i < n; i++)
        {
            int temp = 1;

            for (int l = i - 1; l >= 0; l--)
            {
                if (v[l] <= v[l + 1])
                    temp++;
                else
                    break;
            }

            for (int r = i + 1; r < n; r++)
            {
                if (v[r] <= v[r - 1])
                    temp++;
                else
                    break;
            }

            ans = Math.Max(ans, temp);
        }

        Console.WriteLine(ans);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Petya and Countryside");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}