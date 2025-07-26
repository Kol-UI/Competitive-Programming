// Middle Class
namespace CompetitiveProgramming.CodeForces.MiddleClass;
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
            long[] nx = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long n = nx[0], x = nx[1];
            long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            Array.Sort(a);
            Array.Reverse(a);
            
            long s = 0, ans = 0;
            for (int p = 0; p < n; p++)
            {
                s += a[p];
                if (s < (p + 1) * x) break;
                ans = p + 1;
            }
            
            Console.WriteLine(ans);
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
        StyleHelper.Title("Middle Class");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}