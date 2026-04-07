// Launch of Collider
namespace CompetitiveProgramming.CodeForces.LaunchofCollider;
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
        int n = int.Parse(Console.ReadLine());
        string direction = Console.ReadLine()!;
        string[] positions = Console.ReadLine().Split();
        
        long minDist = -1;
        long lastRight = -1;

        for (int p = 0; p < n; p++)
        {
            int to = direction[p] == 'R' ? 1 : -1;
            long x = long.Parse(positions[p]);
            
            if (to > 0)
            {
                lastRight = x;
            }
            else if (lastRight >= 0 && (minDist < 0 || (x - lastRight < minDist)))
            {
                minDist = x - lastRight;
            }
        }

        long minTime = (minDist < 0) ? -1 : (minDist / 2);
        Console.WriteLine(minTime);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Launch of Collider");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}