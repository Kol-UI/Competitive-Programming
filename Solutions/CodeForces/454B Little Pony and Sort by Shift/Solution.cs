// Little Pony and Sort by Shift
namespace CompetitiveProgramming.CodeForces.LittlePonyandSortbyShift;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        
        long[] array = new long[n];
        for (int p = 0; p < n; p++)
        {
            array[p] = long.Parse(input[p]);
        }

        bool down = false;
        bool possible = true;
        long moves = 0;

        for (int p = 1; p < n; p++)
        {
            if (array[p - 1] <= array[p]) continue;
            if (down)
            {
                possible = false;
                break;
            }
            down = true;
            moves = n - p;
            if (array[p] > array[0])
            {
                possible = false;
                break;
            }
        }

        if (down && array[n - 1] > array[0]) possible = false;

        if (!possible) Console.WriteLine("-1");
        else Console.WriteLine(moves);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Little Pony and Sort by Shift");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}