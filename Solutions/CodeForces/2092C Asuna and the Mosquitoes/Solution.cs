// Asuna and the Mosquitoes
namespace CompetitiveProgramming.CodeForces.AsunaandtheMosquitoes;
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
            long n = long.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            
            long cd = 0;
            long cv = 0;
            long mx = 0;
            long s = 0;
            
            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(input[p]);
                if (x % 2 == 1)
                    cd++;
                else
                    cv++;
                
                if (x > mx) mx = x;
                s += x;
            }
            
            long result = (cd > 0 && cv > 0) ? (s - cd + 1) : mx;
            Console.WriteLine(result);
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
        StyleHelper.Title("Asuna and the Mosquitoes");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}