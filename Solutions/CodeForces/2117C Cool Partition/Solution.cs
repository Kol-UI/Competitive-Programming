// Cool Partition
namespace CompetitiveProgramming.CodeForces.CoolPartition;
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
            
            HashSet<long> ms = new HashSet<long>();
            HashSet<long> fs = new HashSet<long>();
            long cnt = 0;
            
            for (long p = 0; p < n; p++)
            {
                long x = long.Parse(input[p]);
                fs.Add(x);
                
                if (ms.Contains(x))
                {
                    ms.Remove(x);
                }
                
                if (ms.Count == 0)
                {
                    cnt++;
                    ms = new HashSet<long>(fs);
                    fs.Clear();
                }
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
        StyleHelper.Title("Cool Partition");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}