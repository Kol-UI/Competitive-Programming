// Worms
namespace CompetitiveProgramming.CodeForces.Worms;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Collections.Generic;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int n = int.Parse(Console.ReadLine()!);
        string[] a = Console.ReadLine()!.Split();
        List<int> psum = new List<int>();
        psum.Add(0);
        
        for (int i = 0; i < n; i++)
        {
            psum.Add(psum[i] + int.Parse(a[i]));
        }

        int m = int.Parse(Console.ReadLine()!);
        string[] qs = Console.ReadLine()!.Split();
        
        for (int i = 0; i < m; i++)
        {
            int q = int.Parse(qs[i]);
            int low = 1, high = n, ans = n;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (psum[mid] >= q)
                {
                    ans = mid;
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            Console.WriteLine(ans);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Worms");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}