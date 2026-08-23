// Big Segment
namespace CompetitiveProgramming.CodeForces.BigSegment;
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
        long numSegments = long.Parse(Console.ReadLine());
        long[] leftArray = new long[numSegments];
        long[] rightArray = new long[numSegments];
        List<(long, long)> segments = new List<(long, long)>();

        for (int k = 0; k < numSegments; k++)
        {
            string[] input = Console.ReadLine().Split();
            leftArray[k] = long.Parse(input[0]);
            rightArray[k] = long.Parse(input[1]);
            segments.Add((leftArray[k], rightArray[k]));
        }

        Array.Sort(leftArray);
        Array.Sort(rightArray);

        (long, long) target = (leftArray[0], rightArray[numSegments - 1]);

        long pos = -2;
        for (int k = 0; k < numSegments; k++)
        {
            if (segments[k] == target)
            {
                pos = k;
                break;
            }
        }

        Console.WriteLine(pos + 1);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Big Segment");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}
