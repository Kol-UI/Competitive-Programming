// Strange Partition
namespace CompetitiveProgramming.CodeForces.StrangePartition;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            int[] nk = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int n = nk[0];
            int k = nk[1];
            List<int> v = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse).ToList();

            long sum = v.Sum(x => (long)x);
            Console.Write((sum + k - 1) / k + " ");

            long mx = 0;
            for (int i = 0; i < n; i++)
            {
                mx += (v[i] + k - 1) / k;
            }
            Console.WriteLine(mx);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Strange Partition");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}