// Parking
namespace CompetitiveProgramming.Kattis.Parking;
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
        string[] rates = Console.ReadLine().Split();
        int a = int.Parse(rates[0]);
        int b = int.Parse(rates[1]);
        int c = int.Parse(rates[2]);

        Dictionary<int, int> cnt = new Dictionary<int, int>();

        for (int i = 0; i < 3; i++)
        {
            string[] times = Console.ReadLine().Split();
            int l = int.Parse(times[0]);
            int r = int.Parse(times[1]);

            for (int j = l; j < r; j++)
            {
                if (!cnt.ContainsKey(j))
                    cnt[j] = 0;
                cnt[j]++;
            }
        }

        int total = 0;
        foreach (int x in cnt.Values)
        {
            if (x >= 3)
                total += c * x;
            else if (x >= 2)
                total += b * x;
            else
                total += a * x;
        }

        Console.WriteLine(total);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Parking");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}