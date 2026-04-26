// Square Pool
namespace CompetitiveProgramming.CodeForces.SquarePool;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Solution
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string[] firstLine = Console.ReadLine().Split();
            long n = long.Parse(firstLine[0]);
            long s = long.Parse(firstLine[1]);
            
            long total = 0;
            for (long p = 0; p < n; p++)
            {
                string[] input = Console.ReadLine().Split();
                long dx = long.Parse(input[0]);
                long dy = long.Parse(input[1]);
                long x = long.Parse(input[2]);
                long y = long.Parse(input[3]);
                
                if (dx == dy)
                {
                    if (x == y) total++;
                }
                else
                {
                    if (x + y == s) total++;
                }
            }
            
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
        StyleHelper.Title("Square Pool");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}