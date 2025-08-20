// Sages Birthday easy version
namespace CompetitiveProgramming.CodeForces.SagesBirthdayeasyversion;
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
        int n = int.Parse(Console.ReadLine());
        List<long> a = Console.ReadLine().Split().Select(long.Parse).ToList();
        a.Sort();
        a.Reverse();
        
        long last = -1;
        if (n % 2 == 0)
        {
            last = a[a.Count - 1];
            a.RemoveAt(a.Count - 1);
        }
        
        long[] b = new long[a.Count];
        int idx = 0;
        for (int p = 0; p < a.Count; p += 2) b[p] = a[idx++];
        for (int p = 1; p < a.Count; p += 2) b[p] = a[idx++];
        
        if (last > 0)
        {
            List<long> temp = b.ToList();
            temp.Add(last);
            b = temp.ToArray();
        }
        
        Console.WriteLine((n - 1) / 2);
        Console.WriteLine(string.Join(" ", b));
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
        StyleHelper.Title("Sage's Birthday easy version");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}