// Mex Master
namespace CompetitiveProgramming.CodeForces.MexMaster;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

public class Program
{
    //public static void Main(string[] args)
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            int zero = 0, notZero = 0;
            int mx = -1;
            string[] input = Console.ReadLine()!.Split(' ');
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(input[i]);
                if (x == 0) zero++;
                else notZero++;
                mx = Math.Max(mx, x);
            }
            int ans;
            if (notZero >= zero - 1)
            {
                ans = 0;
            }
            else if (mx == 1)
            {
                ans = 2;
            }
            else
            {
                ans = 1;
            }
            Console.WriteLine(ans);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Mex Master");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}