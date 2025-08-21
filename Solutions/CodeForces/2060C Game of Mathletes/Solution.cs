// Game of Mathletes
namespace CompetitiveProgramming.CodeForces.GameofMathletes;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    //public static void Main()
    public static void MainSolution()
    {
        long t = Convert.ToInt64(Console.ReadLine());
        while (t-- > 0)
        {
            var nk = Console.ReadLine().Split().Select(long.Parse).ToList();
            long n = nk[0];
            long k = nk[1];
            
            var v = Console.ReadLine().Split().Select(long.Parse).ToList();
            v.Sort();
            
            long left = 0;
            long right = n - 1;
            long cnt = 0;
            
            while (left < right)
            {
                long sum = v[(int)left] + v[(int)right];
                if (sum == k)
                {
                    cnt++;
                    left++;
                    right--;
                }
                else if (sum < k)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            Console.WriteLine(cnt);
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
        StyleHelper.Title("Game of Mathletes");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}