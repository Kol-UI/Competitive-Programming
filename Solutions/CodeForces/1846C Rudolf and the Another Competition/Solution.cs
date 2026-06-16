// Rudolf and the Another Competition
namespace CompetitiveProgramming.CodeForces.RudolfandtheAnotherCompetition;
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
            string[] firstLine = Console.ReadLine().Split();
            long n = long.Parse(firstLine[0]);
            long m = long.Parse(firstLine[1]);
            long h = long.Parse(firstLine[2]);
            
            string[] input = Console.ReadLine().Split();
            List<long> v = new List<long>();
            for (long p = 0; p < m; p++)
            {
                v.Add(long.Parse(input[p]));
            }
            v.Sort();
            
            long ct = 0;
            long ms = 0;
            long mp = 0;
            
            for (long p = 0; p < m; p++)
            {
                ct += v[(int)p];
                if (ct > h) break;
                ms++;
                mp += ct;
            }
            
            long ans = 1;
            
            for (long idx = 1; idx < n; idx++)
            {
                string[] playerInput = Console.ReadLine().Split();
                List<long> w = new List<long>();
                for (long p = 0; p < m; p++)
                {
                    w.Add(long.Parse(playerInput[p]));
                }
                w.Sort();
                
                ct = 0;
                long cnt = 0;
                long penalty = 0;
                
                for (long p = 0; p < m; p++)
                {
                    ct += w[(int)p];
                    if (ct > h) break;
                    cnt++;
                    penalty += ct;
                }
                
                if (cnt < ms) continue;
                if (cnt > ms) ans++;
                else if (cnt == ms && penalty < mp) ans++;
            }
            
            Console.WriteLine(ans);
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
        StyleHelper.Title("Rudolf and the Another Competition");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}