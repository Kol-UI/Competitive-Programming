// Hourglass
namespace CompetitiveProgramming.CodeForces.Hourglass;
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
            var input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            long s = input[0];
            long k = input[1];
            long m = input[2];
            
            if(s <= k)
            {
                long result = s - (m % k);
                Console.WriteLine(result > 0 ? result : 0);
            }
            else
            {
                long mod = m % (2 * k);
                long value = mod < k ? s : k;
                Console.WriteLine(value - (m % k));
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
        StyleHelper.Title("Hourglass");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}