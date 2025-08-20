// Save More Mice
namespace CompetitiveProgramming.CodeForces.SaveMoreMice;
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
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long[] nk = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long n = nk[0], k = nk[1];
            List<long> dist = new List<long>();
            long[] positions = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            
            foreach (long x in positions)
            {
                dist.Add(n - x);
            }

            dist.Sort();

            long cnt = 0, rem = n;
            for (int p = 0; rem > 0 && p < dist.Count; p++)
            {
                rem -= dist[p];
                if (rem > 0) cnt++;
            }

            Console.WriteLine(cnt);
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
        StyleHelper.Title("Save More Mice");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}