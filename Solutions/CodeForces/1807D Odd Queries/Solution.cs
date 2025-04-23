// Odd Queries
namespace CompetitiveProgramming.CodeForces.OddQueries;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            string[] nq = Console.ReadLine()!.Split();
            int n = int.Parse(nq[0]);
            int q = int.Parse(nq[1]);
            int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            long sum = 0;
            foreach (int num in arr) sum += num;
            bool cur = (sum & 1) == 1;
            long[] psum = new long[n + 1];
            for (int i = 1; i <= n; i++) psum[i] = psum[i - 1] + arr[i - 1];
            
            while (q-- > 0)
            {
                string[] lrk = Console.ReadLine()!.Split();
                int l = int.Parse(lrk[0]);
                int r = int.Parse(lrk[1]);
                int k = int.Parse(lrk[2]);
                long a = psum[r] - (psum[l - 1]);
                long newSum = k * (r - l + 1) + sum - a;
                Console.WriteLine((newSum & 1) == 1 ? "YES" : "NO");
            }
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Odd Queries");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}