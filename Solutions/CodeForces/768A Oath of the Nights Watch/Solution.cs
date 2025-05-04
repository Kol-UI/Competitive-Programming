// Oath of the Night's Watch
namespace CompetitiveProgramming.CodeForces.OathoftheNightsWatch;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int n = int.Parse(Console.ReadLine()!);
        string[] input = Console.ReadLine()!.Split();
        int[] v = new int[n];
        for (int i = 0; i < n; i++)
            v[i] = int.Parse(input[i]);
        
        Array.Sort(v);
        
        int ans;
        if (v[0] != v[n - 1])
        {
            int countFirst = 0;
            int countLast = 0;
            for (int i = 0; i < n; i++)
            {
                if (v[i] == v[0]) countFirst++;
                if (v[i] == v[n - 1]) countLast++;
            }
            ans = n - countFirst - countLast;
        }
        else
        {
            ans = 0;
        }
        
        Console.WriteLine(ans);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Oath of the Night's Watch");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}