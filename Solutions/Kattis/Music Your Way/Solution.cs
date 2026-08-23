// Music Your Way
namespace CompetitiveProgramming.Kattis.MusicYourWay;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] attrs = Console.ReadLine().Split();
        int n = int.Parse(Console.ReadLine());

        List<string[]> songs = new List<string[]>();
        for (int i = 0; i < n; i++)
        {
            songs.Add(Console.ReadLine().Split());
        }

        int m = int.Parse(Console.ReadLine());
        for (int i = 0; i < m; i++)
        {
            string attr = Console.ReadLine();
            int idx = Array.IndexOf(attrs, attr);

            songs = songs.OrderBy(s => s[idx], StringComparer.Ordinal).ToList();

            Console.WriteLine(string.Join(" ", attrs));
            foreach (var song in songs)
            {
                Console.WriteLine(string.Join(" ", song));
            }
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
        StyleHelper.Title("Music Your Way");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}