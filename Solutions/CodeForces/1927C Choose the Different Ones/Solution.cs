// Choose the Different Ones
namespace CompetitiveProgramming.CodeForces.ChoosetheDifferentOnes;
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
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = input[0], m = input[1], k = input[2];
            
            bool[] a = new bool[k + 1];
            bool[] b = new bool[k + 1];
            
            int[] numsA = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            foreach (int x in numsA) if (x <= k) a[x] = true;
            
            int[] numsB = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            foreach (int x in numsB) if (x <= k) b[x] = true;
            
            bool possible = true;
            int u = 0, v = 0, w = 0;
            
            for (int p = 1; possible && p <= k; p++)
            {
                if (a[p] && b[p]) w++;
                else if (a[p]) u++;
                else if (b[p]) v++;
                else possible = false;
            }
            
            possible = possible && (u + w >= k / 2) && (v + w >= k / 2);
            Console.WriteLine(possible ? "YES" : "NO");
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
        StyleHelper.Title("Choose the Different Ones");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}