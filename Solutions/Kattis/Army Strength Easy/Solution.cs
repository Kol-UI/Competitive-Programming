// Army Strength (Easy)
namespace CompetitiveProgramming.Kattis.ArmyStrengthEasy;
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
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.ReadLine();
            string[] sizes = Console.ReadLine().Split();
            int gSize = int.Parse(sizes[0]);
            int mSize = int.Parse(sizes[1]);
            
            List<int> g = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> m = Console.ReadLine().Split().Select(int.Parse).ToList();
            
            int gMax = g.Max();
            int mMax = m.Max();
            
            if (gMax >= mMax)
                Console.WriteLine("Godzilla");
            else
                Console.WriteLine("MechaGodzilla");
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
        StyleHelper.Title("Army Strength (Easy)");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}