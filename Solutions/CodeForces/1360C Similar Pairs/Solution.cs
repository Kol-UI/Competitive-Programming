// Similar Pairs
namespace CompetitiveProgramming.CodeForces.SimilarPairs;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            int[] v = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int odd = v.Count(x => x % 2 != 0);
            int even = n - odd;
            bool ok = false;

            if (even % 2 == 0 && odd % 2 == 0)
                ok = true;
            
            if (!ok)
            {
                Array.Sort(v);
                for (int i = 1; i < n; i++)
                {
                    if (v[i] - v[i - 1] == 1)
                    {
                        ok = true;
                        break;
                    }
                }
            }

            Console.WriteLine(ok ? "YES" : "NO");
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Similar Pairs");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}