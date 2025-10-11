// The Great Hero
namespace CompetitiveProgramming.CodeForces.TheGreatHero;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int testCases = int.Parse(Console.ReadLine());
        
        for (int testCase = 0; testCase < testCases; testCase++)
        {
            long[] firstLine = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long A = firstLine[0];
            long B = firstLine[1];
            long n = firstLine[2];
            
            long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long[] b = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            long maxAttack = 0;
            for (int p = 0; p < n; p++)
            {
                long rounds = (b[p] + A - 1) / A;
                B -= rounds * a[p];
                maxAttack = Math.Max(maxAttack, a[p]);
            }
            
            Console.WriteLine(B + maxAttack > 0 ? "YES" : "NO");
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
        StyleHelper.Title("The Great Hero");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}