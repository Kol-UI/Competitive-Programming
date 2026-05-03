// Secure Doors
namespace CompetitiveProgramming.Kattis.SecureDoors;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, bool> people = new Dictionary<string, bool>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string s1 = input[0];
            string s2 = input[1];

            if (!people.ContainsKey(s2))
            {
                people[s2] = false;
            }

            if (s1 == "entry")
            {
                if (people[s2])
                {
                    Console.WriteLine($"{s2} entered (ANOMALY)");
                }
                else
                {
                    people[s2] = true;
                    Console.WriteLine($"{s2} entered");
                }
            }
            else
            {
                if (people[s2])
                {
                    people[s2] = false;
                    Console.WriteLine($"{s2} exited");
                }
                else
                {
                    Console.WriteLine($"{s2} exited (ANOMALY)");
                }
            }
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Secure Doors");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}