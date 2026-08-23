// Shopping List
namespace CompetitiveProgramming.Kattis.ShoppingList;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int m = int.Parse(firstLine[1]);

        HashSet<string> s = new HashSet<string>(Console.ReadLine().Split());

        for (int i = 0; i < n - 1; i++)
        {
            HashSet<string> current = new HashSet<string>(Console.ReadLine().Split());
            s.IntersectWith(current);
        }

        Console.WriteLine(s.Count);
        foreach (string x in s.OrderBy(x => x))
        {
            Console.WriteLine(x);
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Shopping List");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}