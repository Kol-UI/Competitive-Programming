// Collecting Packages
namespace CompetitiveProgramming.CodeForces.CollectingPackages;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            List<(long, long)> a = new List<(long, long)>();
            
            for (long p = 0; p < n; p++)
            {
                string[] input = Console.ReadLine().Split();
                long first = long.Parse(input[0]);
                long second = long.Parse(input[1]);
                a.Add((first, second));
            }
            
            a = a.OrderBy(pair => pair.Item1).ThenBy(pair => pair.Item2).ToList();
            
            bool possible = true;
            string path = "";
            long x = 0;
            long y = 0;
            
            for (long p = 0; p < n; p++)
            {
                while (x < a[(int)p].Item1)
                {
                    x++;
                    path += 'R';
                }
                if (a[(int)p].Item2 < y)
                {
                    possible = false;
                    break;
                }
                while (y < a[(int)p].Item2)
                {
                    y++;
                    path += 'U';
                }
            }
            
            if (possible)
            {
                Console.WriteLine("YES");
                Console.WriteLine(path);
            }
            else
            {
                Console.WriteLine("NO");
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
        StyleHelper.Title("Collecting Packages");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}