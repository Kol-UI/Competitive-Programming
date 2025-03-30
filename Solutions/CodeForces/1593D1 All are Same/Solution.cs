// All are Same
namespace CompetitiveProgramming.CodeForces.AllareSame;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);

    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine()!);
            var v = Console.ReadLine()!.Split().Select(int.Parse).ToList();
            v.Sort();
            int k = 0;
            var temp = new List<int>();
            
            for (int i = 1; i < n; i++)
            {
                if (v[i] != v[i - 1])
                    temp.Add(Math.Abs(v[i] - v[i - 1]));
            }
            
            foreach (var val in temp)
                k = GCD(k, val);
            
            if (k == 0) k = -1;
            Console.WriteLine(k);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("All are Same");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}