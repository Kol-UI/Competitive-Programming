// Elevating the Prank
namespace CompetitiveProgramming.Kattis.ElevatingthePrank;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;
using System.Linq;

class Solution
{
    static void Main()
    {
        string[] first = Console.ReadLine().Split();
        int a = int.Parse(first[0]);
        int b = int.Parse(first[1]);
        int n = int.Parse(Console.ReadLine());

        if (a > b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        HashSet<int> l = new HashSet<int>();
        for (int i = 0; i < n; i++)
            l.Add(int.Parse(Console.ReadLine()));

        if (a == b)
        {
            Console.WriteLine(0);
            return;
        }

        int s = l.Where(x => a < x && x < b).Sum(x => 10);

        Console.WriteLine(4 * (b - a) + s);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Elevating the Prank");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}