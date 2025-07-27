// Parity and Sum
namespace CompetitiveProgramming.CodeForces.ParityandSum;
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
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            List<long> v = new List<long>();
            long mxodd = 0;
            
            long[] nums = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            foreach (long x in nums)
            {
                if (x % 2 != 0) mxodd = Math.Max(mxodd, x);
                else v.Add(x);
            }

            if (v.Count == n)
            {
                Console.WriteLine("0");
                continue;
            }

            v.Sort();
            long cnt = v.Count;

            foreach (long num in v)
            {
                if (mxodd > v.Last()) break;
                if (mxodd < num)
                {
                    cnt++;
                    break;
                }
                mxodd += num;
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
        StyleHelper.Title("Parity and Sum");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}