// Circle of Students
namespace CompetitiveProgramming.CodeForces.CircleofStudents;
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
        long q = long.Parse(Console.ReadLine());
        while (q-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            bool up = true, down = true;
            string[] input = Console.ReadLine().Split();
            long prev = long.Parse(input[0]);
            
            for (long p = 1; p < n; p++)
            {
                long x = long.Parse(input[p]);
                if (up)
                {
                    if (x == prev + 1) { }
                    else if (x == 1 && prev == n) { }
                    else { up = false; }
                }
                if (down)
                {
                    if (x == prev - 1) { }
                    else if (x == n && prev == 1) { }
                    else { down = false; }
                }
                prev = x;
            }
            
            Console.WriteLine(up || down ? "YES" : "NO");
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
        StyleHelper.Title("Circle of Students");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}