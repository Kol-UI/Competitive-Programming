// Sail
namespace CompetitiveProgramming.CodeForces.Sail;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Solution
{
    static void Main()
    {
        string line1 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(line1)) return;

        string[] parts = line1.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        long n = long.Parse(parts[0]);
        long sx = long.Parse(parts[1]);
        long sy = long.Parse(parts[2]);
        long ex = long.Parse(parts[3]);
        long ey = long.Parse(parts[4]);

        string s = Console.ReadLine();

        char horizontal = 'E';
        long goalX = ex - sx;
        if (goalX < 0) { goalX = -goalX; horizontal = 'W'; }

        char vertical = 'N';
        long goalY = ey - sy;
        if (goalY < 0) { goalY = -goalY; vertical = 'S'; }

        long distX = 0, distY = 0;
        long t = 0;

        for (t = 1; t <= n && t <= s.Length; t++)
        {
            char temp = s[(int)(t - 1)];
            if (temp == horizontal) { ++distX; }
            else if (temp == vertical) { ++distY; }
            if (distX >= goalX && distY >= goalY) { break; }
        }

        if (distX >= goalX && distY >= goalY)
        {
            Console.WriteLine(t);
        }
        else
        {
            Console.WriteLine("-1");
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Sail");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}