// Minimize Inversions
namespace CompetitiveProgramming.CodeForces.MinimizeInversions;
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
            long[] firstArray = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long[] secondArray = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            List<Tuple<long, long>> v = new List<Tuple<long, long>>();
            for (long p = 0; p < n; p++)
            {
                v.Add(Tuple.Create(firstArray[p], secondArray[p]));
            }
            v = v.OrderBy(x => x.Item1).ToList();
            foreach (var item in v) Console.Write(item.Item1 + " ");
            Console.WriteLine();
            foreach (var item in v) Console.Write(item.Item2 + " ");
            Console.WriteLine();
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
        StyleHelper.Title("Minimize Inversions");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}