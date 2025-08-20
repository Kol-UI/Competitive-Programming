// Minimize Equal Sum Subarrays
namespace CompetitiveProgramming.CodeForces.MinimizeEqualSumSubarrays;
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
            int n = int.Parse(Console.ReadLine());
            long[] v = new long[n];
            
            string[] inputs = Console.ReadLine().Split();
            for (int p = 0; p < n; p++)
            {
                v[p] = long.Parse(inputs[p]);
            }
            
            long last = v[n - 1];
            for (int p = n - 1; p > 0; p--)
            {
                v[p] = v[p - 1];
            }
            v[0] = last;
            
            Console.WriteLine(string.Join(" ", v));
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
        StyleHelper.Title("Minimize Equal Sum Subarrays");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}