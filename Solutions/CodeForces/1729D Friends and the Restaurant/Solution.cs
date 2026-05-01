// Friends and the Restaurant
namespace CompetitiveProgramming.CodeForces.FriendsandtheRestaurant;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            long[] x = new long[n];
            long[] y = new long[n];
            
            string[] xInput = Console.ReadLine().Split();
            for (long p = 0; p < n; p++) x[p] = long.Parse(xInput[p]);
            
            string[] yInput = Console.ReadLine().Split();
            for (long p = 0; p < n; p++) y[p] = long.Parse(yInput[p]);
            
            List<long> pos = new List<long>();
            List<long> neg = new List<long>();
            long cnt = 0, rem = 0;
            
            for (long p = 0; p < n; p++)
            {
                long diff = y[p] - x[p];
                if (diff < 0) neg.Add(diff);
                else if (diff > 0) { pos.Add(diff); rem++; }
                else rem++;
            }
            
            neg.Sort((a, b) => b.CompareTo(a));
            pos.Sort();
            
            long idx = 0;
            foreach (long val in neg)
            {
                while (idx < pos.Count && pos[(int)idx] + val < 0) idx++;
                if (idx < pos.Count && pos[(int)idx] + val >= 0)
                {
                    idx++;
                    cnt++;
                    rem--;
                }
            }
            
            cnt += rem / 2;
            Console.WriteLine(cnt);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Friends and the Restaurant");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}