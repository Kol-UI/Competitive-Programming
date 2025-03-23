// Three Parts of the Array
namespace CompetitiveProgramming.CodeForces.ThreePartsoftheArray;
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
        long[] v = Array.ConvertAll(Console.ReadLine()!.Split(), long.Parse);

        if (n == 1)
        {
            Console.WriteLine(0);
            return;
        }

        long l = 1, r = n - 2;
        long suml = v[0], sumr = v[n - 1];
        long ans = suml * (suml == sumr ? 1 : 0);

        while (l <= r)
        {
            if (suml <= sumr)
            {
                suml += v[l];
                l++;
            }
            else
            {
                sumr += v[r];
                r--;
            }

            if (suml == sumr)
            {
                ans = sumr;
            }
        }

        Console.WriteLine(ans);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Three Parts of the Array");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}