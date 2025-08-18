// Count the Number of Pairs
namespace CompetitiveProgramming.CodeForces.CounttheNumberofPairs;
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
        const int B = 26;
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = nk[0], k = nk[1];
            string s = Console.ReadLine();
            int[] v = new int[B];
            int ans = 0;

            foreach (char c in s)
            {
                if ('a' <= c && c <= 'z')
                {
                    int idx = c - 'a';
                    if (v[idx] < 0) ans++;
                    v[idx]++;
                }
                else if ('A' <= c && c <= 'Z')
                {
                    int idx = c - 'A';
                    if (v[idx] > 0) ans++;
                    v[idx]--;
                }
            }

            for (int p = 0; p < B; p++)
            {
                int cur = Math.Abs(v[p] / 2);
                cur = Math.Min(cur, k);
                ans += cur;
                k -= cur;
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
        StyleHelper.Title("Count the Number of Pairs");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}