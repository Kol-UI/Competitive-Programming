// Mahmoud and a Triangle
namespace CompetitiveProgramming.CodeForces.MahmoudandaTriangle;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        Array.Sort(v);
        bool possible = false;
        
        for (int i = 0; i < n - 2; i++)
        {
            if (v[i] + v[i+1] > v[i+2])
            {
                possible = true;
                break;
            }
        }
        
        Console.WriteLine(possible ? "YES" : "NO");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
#pragma warning restore CS8600
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Mahmoud and a Triangle");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}