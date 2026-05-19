// Stand-up Comedian
namespace CompetitiveProgramming.CodeForces.StandupComedian;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] input = Console.ReadLine().Split();
            long a = long.Parse(input[0]);
            long b = long.Parse(input[1]);
            long c = long.Parse(input[2]);
            long d = long.Parse(input[3]);
            
            long cnt = a;
            long m = (b < c) ? b : c;
            if (a > 0)
            {
                cnt += 2 * m;
                b -= m;
                c -= m;
            }
            
            if (b > 0)
            {
                long more = (a < b) ? a : b;
                b -= more;
                a -= more;
                cnt += more;
            }
            else
            {
                long more = (a < c) ? a : c;
                c -= more;
                a -= more;
                cnt += more;
            }
            
            if (a > 0)
            {
                long more = (a < d) ? a : d;
                d -= more;
                a -= more;
                cnt += more;
            }
            
            if (b > 0 || c > 0 || d > 0)
            {
                cnt++;
            }
            
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
        StyleHelper.Title("Stand-up Comedian");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}