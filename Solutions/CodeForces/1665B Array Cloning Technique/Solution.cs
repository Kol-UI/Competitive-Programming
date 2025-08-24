// Array Cloning Technique
namespace CompetitiveProgramming.CodeForces.ArrayCloningTechnique;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            Dictionary<long, long> m = new Dictionary<long, long>();
            long cnt = 0;
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            foreach (long x in arr)
            {
                if (!m.ContainsKey(x)) m[x] = 0;
                m[x]++;
                cnt = Math.Max(cnt, m[x]);
            }
            long res = 0;
            while (cnt < n)
            {
                long diff = Math.Min(cnt, n - cnt);
                res += 1 + diff;
                cnt *= 2;
            }
            Console.WriteLine(res);
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
        StyleHelper.Title("Array Cloning Technique");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}