// Bicycle Chain
namespace CompetitiveProgramming.CodeForces.BicycleChain;
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
        int n = int.Parse(Console.ReadLine());
        int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        
        int m = int.Parse(Console.ReadLine());
        int[] b = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        
        int ratio = 0;
        int maxRatio = -1;
        int count = 0;
        int stopIndex = n - 1;
        
        for (int p = m - 1; p >= 0; p--)
        {
            for (int q = 0; q <= stopIndex; q++)
            {
                if (b[p] % a[q] == 0)
                {
                    ratio = b[p] / a[q];
                    if (ratio > maxRatio)
                    {
                        maxRatio = ratio;
                        count = 1;
                    }
                    else if (ratio == maxRatio)
                    {
                        count++;
                    }
                    stopIndex = q;
                    break;
                }
            }
        }
        
        Console.WriteLine(count);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Bicycle Chain");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}