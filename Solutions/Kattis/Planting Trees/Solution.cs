// Planting Trees
namespace CompetitiveProgramming.Kattis.PlantingTrees;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int trees = int.Parse(Console.ReadLine());
        int[] t = new int[trees + 1];
        
        string[] input = Console.ReadLine().Split();
        for (int i = 0; i < trees; i++)
        {
            t[i] = int.Parse(input[i]);
        }
        
        Array.Sort(t, (a, b) => b.CompareTo(a));
        
        int partayTime = 0;
        for (int i = 0; i < trees; i++)
        {
            if (t[i] + i > partayTime)
            {
                partayTime = t[i] + i;
            }
        }
        
        Console.WriteLine(partayTime + 2);
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Planting Trees");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}