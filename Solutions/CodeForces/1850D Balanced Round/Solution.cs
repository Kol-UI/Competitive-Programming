// Balanced Round
namespace CompetitiveProgramming.CodeForces.BalancedRound;
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
            int[] nk = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int n = nk[0], k = nk[1];
            int[] v = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            Array.Sort(v);
            int mx = 1, temp = 1;
            for (int i = 0; i + 1 < n; i++)
            {
                if (Math.Abs(v[i] - v[i + 1]) <= k)
                {
                    temp++;
                    mx = Math.Max(mx, temp);
                }
                else
                {
                    temp = 1;
                }
            }
            Console.WriteLine(n - mx);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Balanced Round");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}