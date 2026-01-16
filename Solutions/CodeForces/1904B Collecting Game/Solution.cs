// Collecting Game
namespace CompetitiveProgramming.CodeForces.CollectingGame;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;
using System.Collections.Generic;

public class HelloWorld
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            List<(long value, int index)> pairs = new List<(long, int)>();
            for(int p = 0; p < n; p++)
            {
                pairs.Add((a[p], p));
            }
            
            var sorted = pairs.OrderBy(x => x.value).ToList();
            
            long[] prefixSum = new long[n];
            prefixSum[0] = sorted[0].value;
            for(int p = 1; p < n; p++)
            {
                prefixSum[p] = prefixSum[p - 1] + sorted[p].value;
            }
            
            int[] result = new int[n];
            int[] stop = new int[n];
            
            for(int p = 0; p < n - 1; p++)
            {
                if(prefixSum[p] < sorted[p + 1].value)
                {
                    stop[p] = 1;
                }
            }
            
            int idx = n - 1;
            for(int p = n - 1; p >= 0; p--)
            {
                if(stop[p] == 1)
                {
                    idx = p;
                }
                stop[p] = idx;
            }
            
            for(int p = 0; p < n; p++)
            {
                result[sorted[p].index] = stop[p];
            }
            
            Console.WriteLine(string.Join(" ", result.Select(x => x.ToString()).ToArray()));
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Collecting Game");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}