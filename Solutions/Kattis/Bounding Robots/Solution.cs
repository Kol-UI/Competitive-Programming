// Bounding Robots
namespace CompetitiveProgramming.Kattis.BoundingRobots;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Program
{
    static int Range(int small, int large, int val)
    {
        int ans = val;
        if (ans > large) ans = large;
        if (ans < small) ans = small;
        return ans;
    }

    static void Main()
    {
        string line;
        while ((line = Console.ReadLine()) != null)
        {
            string[] wh = line.Split();
            int w = int.Parse(wh[0]);
            int l = int.Parse(wh[1]);
            if (w == 0 && l == 0) break;

            int n = int.Parse(Console.ReadLine());

            int actualX = 0, robotX = 0;
            int actualY = 0, robotY = 0;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                char dir = char.Parse(input[0]);
                int dist = int.Parse(input[1]);

                if (dir == 'u')
                {
                    robotY += dist;
                    actualY += dist;
                }
                if (dir == 'd')
                {
                    robotY -= dist;
                    actualY -= dist;
                }
                if (dir == 'l')
                {
                    robotX -= dist;
                    actualX -= dist;
                }
                if (dir == 'r')
                {
                    robotX += dist;
                    actualX += dist;
                }

                actualY = Range(0, l - 1, actualY);
                actualX = Range(0, w - 1, actualX);
            }

            Console.WriteLine($"Robot thinks {robotX} {robotY}");
            Console.WriteLine($"Actually at {actualX} {actualY}");
            Console.WriteLine();
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Title");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}