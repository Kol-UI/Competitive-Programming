// The Secret Number
namespace CompetitiveProgramming.CodeForces.TheSecretNumber;
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
            long div = 1;
            List<long> v = new List<long>();
            for (int p = 0; p < 17; p++)
            {
                div *= 10;
                if (n % (div + 1) != 0) continue;
                v.Add(n / (div + 1));
            }
            Console.WriteLine(v.Count);
            if (v.Count == 0) continue;
            v.Sort();
            foreach (long r in v) Console.Write(r + " ");
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
        StyleHelper.Title("The Secret Number");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}