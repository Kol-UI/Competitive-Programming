// Make Equal Again
namespace CompetitiveProgramming.CodeForces.MakeEqualAgain;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            long left = 1;
            while (left < n && a[left] == a[0]) left++;
            
            long right = 1;
            while (right + 1 <= n && a[n - 1 - right] == a[n - 1]) right++;
            
            long s = left > right ? left : right;
            if (a[0] == a[n - 1]) s = left + right;
            s = s < n ? s : n;
            
            Console.WriteLine(n - s);
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
        StyleHelper.Title("Make Equal Again");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}