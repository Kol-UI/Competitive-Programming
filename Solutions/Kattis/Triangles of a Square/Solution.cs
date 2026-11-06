// Triangles of a Square
namespace CompetitiveProgramming.Kattis.TrianglesofaSquare;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Collections.Generic;

class Solution
{
    static void Main()
    {
        string[] vals = Console.ReadLine().Split();
        int x1 = int.Parse(vals[0]);
        int y1 = int.Parse(vals[1]);
        int x2 = int.Parse(vals[2]);
        int y2 = int.Parse(vals[3]);

        var corn = new HashSet<(int, int)> { (0, 0), (0, 2024), (2024, 0), (2024, 2024) };

        int ans = 2;
        if (corn.Contains((x1, y1))) ans--;
        if (corn.Contains((x2, y2))) ans--;

        Console.WriteLine(ans);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Triangles of a Square");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}