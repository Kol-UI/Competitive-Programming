// Video Speedup
namespace CompetitiveProgramming.Kattis.VideoSpeedup;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int p = int.Parse(firstLine[1]);
        int k = int.Parse(firstLine[2]);

        int[] ts = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] times = new int[ts.Length + 2];
        times[0] = 0;
        for (int i = 0; i < ts.Length; i++)
            times[i + 1] = ts[i];
        times[times.Length - 1] = k;

        double ans = 0.0;
        for (int i = 0; i < times.Length - 1; i++)
        {
            int t = times[i + 1] - times[i];
            ans += (100.0 + i * p) * t / 100.0;
        }

        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Video Speedup");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}