// Eating Queries
namespace CompetitiveProgramming.CodeForces.EatingQueries;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int[] nq = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nq[0], q = nq[1];
            int[] v = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            
            Array.Sort(v);
            Array.Reverse(v);
            for (int p = 1; p < n; p++) v[p] += v[p - 1];
            
            while (q-- > 0)
            {
                int x = int.Parse(Console.ReadLine());
                if (x > v[n - 1])
                {
                    Console.WriteLine("-1");
                    continue;
                }
                
                int left = 0, right = n - 1, res = n - 1;
                while (left <= right)
                {
                    int mid = (left + right) / 2;
                    if (x <= v[mid])
                    {
                        res = mid + 1;
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                
                Console.WriteLine(res);
            }
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Eating Queries");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}