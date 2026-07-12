// Not Amused
namespace CompetitiveProgramming.Kattis.NotAmused;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int daycnt = 0;

        while (true)
        {
            string line = Console.ReadLine();
            if (line == null) break;

            daycnt++;
            Dictionary<string, int> pay = new Dictionary<string, int>();
            Dictionary<string, int> ptime = new Dictionary<string, int>();

            while (true)
            {
                string s = Console.ReadLine();
                if (s == "CLOSE") break;

                string[] parts = s.Split();
                string cmd = parts[0];
                string name = parts[1];
                int t = int.Parse(parts[2]);

                if (cmd == "ENTER")
                {
                    ptime[name] = t;
                }
                else
                {
                    if (!pay.ContainsKey(name))
                        pay[name] = 0;
                    pay[name] += t - ptime[name];
                }
            }

            Console.WriteLine($"Day {daycnt}");

            foreach (string name in pay.Keys.OrderBy(x => x))
            {
                Console.WriteLine($"{name} ${pay[name] * 0.1:F2}");
            }

            Console.WriteLine();
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
        StyleHelper.Title("Not Amused");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}