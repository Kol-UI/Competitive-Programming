// Outstanding Impressionist
namespace CompetitiveProgramming.CodeForces.OutstandingImpressionist;
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
            
            long[] vl = new long[n];
            long[] vr = new long[n];
            HashSet<long> fs = new HashSet<long>();
            HashSet<long> gs = new HashSet<long>();
            
            for (long p = 0; p < n; p++)
            {
                string[] input = Console.ReadLine().Split();
                vl[p] = long.Parse(input[0]);
                vr[p] = long.Parse(input[1]);
                
                if (vl[p] == vr[p])
                {
                    if (fs.Contains(vl[p]))
                        gs.Add(vl[p]);
                    else
                        fs.Add(vl[p]);
                }
            }
            
            List<long> dv = fs.ToList();
            dv.Sort();
            
            for (long p = 0; p < n; p++)
            {
                if (vl[p] == vr[p])
                {
                    Console.Write(gs.Contains(vl[p]) ? '0' : '1');
                }
                else
                {
                    int idxA = dv.BinarySearch(vl[p]);
                    if (idxA < 0) idxA = ~idxA;
                    int idxB = dv.BinarySearch(vr[p]);
                    if (idxB < 0) idxB = ~idxB;
                    
                    bool cond = fs.Contains(vl[p]) && fs.Contains(vr[p]) && (idxB - idxA == vr[p] - vl[p]);
                    Console.Write(cond ? '0' : '1');
                }
            }
            Console.WriteLine();
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
        StyleHelper.Title("Outstanding Impressionist");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}