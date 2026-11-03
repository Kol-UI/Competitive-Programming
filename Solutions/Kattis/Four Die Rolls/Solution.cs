// Four Die Rolls
namespace CompetitiveProgramming.Kattis.FourDieRolls;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Solution
{
    static (long, long) Search(List<long> v)
    {
        if (v.Count == 4)
        {
            long a = 0;
            long b = 0;
            bool f = false;
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    if (v[i] == v[j])
                    {
                        f = true;
                        break;
                    }
                }
                if (f) break;
            }
            a += f ? 0 : 1;
            b += f ? 1 : 0;
            return (a, b);
        }

        long ra = 0;
        long rb = 0;
        for (int i = 1; i <= 6; i++)
        {
            v.Add(i);
            var (x, y) = Search(v);
            v.RemoveAt(v.Count - 1);
            ra += x;
            rb += y;
        }
        return (ra, rb);
    }

    static void Main()
    {
        List<long> nums = new List<long>();
        long n = long.Parse(Console.ReadLine());
        string[] vals = Console.ReadLine().Split();
        for (long i = 0; i < n; i++)
        {
            nums.Add(long.Parse(vals[i]));
        }
        var (a, b) = Search(nums);
        Console.WriteLine(a + " " + b);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Four Die Rolls");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}