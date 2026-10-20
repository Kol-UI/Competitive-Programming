// Queue
namespace CompetitiveProgramming.CodeForces.Queue;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Solution
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long[] times = new long[n];
        string[] vals = Console.ReadLine().Split();
        for (int p = 0; p < n; p++) times[p] = long.Parse(vals[p]);
        Array.Sort(times);

        long count = 0;
        long waitTime = 0;
        for (int p = 0; p < n; p++)
        {
            if (waitTime <= times[p])
            {
                waitTime += times[p];
                count++;
            }
        }

        Console.WriteLine(count);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Queue");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1300);
    }
}