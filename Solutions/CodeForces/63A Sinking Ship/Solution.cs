// Sinking Ship
namespace CompetitiveProgramming.CodeForces.SinkingShip;
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
        int n = int.Parse(Console.ReadLine());
        List<string> rats = new List<string>();
        List<string> womenAndChildren = new List<string>();
        List<string> men = new List<string>();
        string captain = "";
        
        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            string[] parts = line.Split(' ');
            string name = parts[0];
            string role = parts[1];
            
            switch (role)
            {
                case "captain":
                    captain = name;
                    break;
                case "rat":
                    rats.Add(name);
                    break;
                case "woman":
                case "child":
                    womenAndChildren.Add(name);
                    break;
                default:
                    men.Add(name);
                    break;
            }
        }
        
        foreach (string name in rats) Console.WriteLine(name);
        foreach (string name in womenAndChildren) Console.WriteLine(name);
        foreach (string name in men) Console.WriteLine(name);
        Console.WriteLine(captain);
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
        StyleHelper.Title("Sinking Ship");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}