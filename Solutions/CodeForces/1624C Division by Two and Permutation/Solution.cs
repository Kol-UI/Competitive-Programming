// Division by Two and Permutation
namespace CompetitiveProgramming.CodeForces.DivisionbyTwoandPermutation;
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
            bool[] v = new bool[n + 1];
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            foreach (int x in nums)
            {
                int current = x;
                while (current > 0)
                {
                    if (current <= n && !v[current])
                    {
                        v[current] = true;
                        break;
                    }
                    current /= 2;
                }
            }

            bool res = true;
            for (int p = 1; p <= n; p++)
            {
                if (!v[p])
                {
                    res = false;
                    break;
                }
            }

            Console.WriteLine(res ? "YES" : "NO");
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
        StyleHelper.Title("Division by Two and Permutation");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}