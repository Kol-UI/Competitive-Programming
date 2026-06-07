// Baby Bites
namespace CompetitiveProgramming.Kattis.BabyBites;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        bool works = true;
        
        for (int i = 0; i < n; i++)
        {
            if (input[i] == "mumble") continue;
            
            if (!int.TryParse(input[i], out int t) || t != i + 1)
            {
                works = false;
                break;
            }
        }
        
        Console.WriteLine(works ? "makes sense" : "something is fishy");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Baby Bites");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}