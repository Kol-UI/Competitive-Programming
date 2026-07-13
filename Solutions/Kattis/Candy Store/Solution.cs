// Candy Store
namespace CompetitiveProgramming.Kattis.CandyStore;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int n = int.Parse(firstLine[0]);
        int q = int.Parse(firstLine[1]);

        Dictionary<string, List<string>> mp = new Dictionary<string, List<string>>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string a = input[0];
            string b = input[1];

            string key = a[0].ToString() + b[0];
            if (!mp.ContainsKey(key))
                mp[key] = new List<string>();
            mp[key].Add($"{a} {b}");
        }

        for (int i = 0; i < q; i++)
        {
            string query = Console.ReadLine();
            if (!mp.ContainsKey(query))
                Console.WriteLine("nobody");
            else if (mp[query].Count > 1)
                Console.WriteLine("ambiguous");
            else
                Console.WriteLine(mp[query][0]);
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
        StyleHelper.Title("Candy Store");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}