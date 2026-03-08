// Increase/Decrease/Copy
namespace CompetitiveProgramming.CodeForces.IncreaseDecreaseCopy;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

public class Solution
{
    static public void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        for(int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            long[] a = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long[] b = Console.ReadLine().Split().Select(long.Parse).ToArray();
            
            long total = 0;
            long minDiff = long.MaxValue;
            
            for(int p = 0; p < n; p++)
            {
                total += Math.Abs(a[p] - b[p]);
                long diff = Math.Abs(a[p] - b[n]);
                if(diff < minDiff) minDiff = diff;
                diff = Math.Abs(b[p] - b[n]);
                if(diff < minDiff) minDiff = diff;
            }
            
            for(int p = 0; p < n; p++)
            {
                if((a[p] <= b[n] && b[n] <= b[p]) || (b[p] <= b[n] && b[n] <= a[p]))
                {
                    minDiff = 0;
                    break;
                }
            }
            
            total += minDiff + 1;
            Console.WriteLine(total);
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
        StyleHelper.Title("Increase/Decrease/Copy");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}