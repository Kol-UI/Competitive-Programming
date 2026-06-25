// Informatics in MAC
namespace CompetitiveProgramming.CodeForces.InformaticsinMAC;
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
            string[] input = Console.ReadLine().Split();
            
            Dictionary<long, long> first = new Dictionary<long, long>();
            Dictionary<long, long> last = new Dictionary<long, long>();
            
            for (long p = 1; p <= n; p++)
            {
                long x = long.Parse(input[p - 1]);
                if (!first.ContainsKey(x)) first[x] = p;
                last[x] = p;
            }
            
            bool possible = true;
            long left = 1;
            long right = n;
            
            for (long p = 0; p < n; p++)
            {
                if (!first.ContainsKey(p)) break;
                if (first[p] == last[p])
                {
                    possible = false;
                    break;
                }
                
                if (first[p] > left) left = first[p];
                if (last[p] < right) right = last[p];
                
                if (left > right)
                {
                    possible = false;
                    break;
                }
            }
            
            if (possible)
            {
                Console.WriteLine($"2\n1 {left}\n{left + 1} {n}");
            }
            else
            {
                Console.WriteLine("-1");
            }
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
        StyleHelper.Title("Informatics in MAC");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}