// Kuriyama Mirai's Stones
namespace CompetitiveProgramming.CodeForces.KuriyamaMiraisStones;
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
        int n = int.Parse(Console.ReadLine()!);
        long[] v = Array.ConvertAll(Console.ReadLine()!.Split(), long.Parse);
        long[] psum = new long[n + 1];
        for (int i = 0; i < n; i++)
            psum[i + 1] = psum[i] + v[i];

        long[] sortedV = v.OrderBy(x => x).ToArray();
        long[] sortedPsum = new long[n + 1];
        for (int i = 0; i < n; i++)
            sortedPsum[i + 1] = sortedPsum[i] + sortedV[i];

        int m = int.Parse(Console.ReadLine()!);
        while (m-- > 0)
        {
            long[] query = Array.ConvertAll(Console.ReadLine()!.Split(), long.Parse);
            long t = query[0], l = query[1], r = query[2];
            Console.WriteLine(t == 1 ? psum[r] - psum[l - 1] : sortedPsum[r] - sortedPsum[l - 1]);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Kuriyama Mirai's Stones");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}