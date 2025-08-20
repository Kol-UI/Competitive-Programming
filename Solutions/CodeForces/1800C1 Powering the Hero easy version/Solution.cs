// Powering the Hero easy version
namespace CompetitiveProgramming.CodeForces.PoweringtheHeroeasyversion;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            PriorityQueue<long, long> pq = new PriorityQueue<long, long>(Comparer<long>.Create((x, y) => y.CompareTo(x)));
            long res = 0;
            
            long[] numbers = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            foreach (long x in numbers)
            {
                if (x != 0)
                {
                    pq.Enqueue(x, x);
                }
                else if (pq.Count > 0)
                {
                    res += pq.Dequeue();
                }
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
        StyleHelper.Title("Powering the Hero easy version");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}