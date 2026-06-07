// GCVWR
namespace CompetitiveProgramming.Kattis.GCVWR;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] firstLine = Console.ReadLine().Split();
        int a = int.Parse(firstLine[0]);
        int b = int.Parse(firstLine[1]);
        int c = int.Parse(firstLine[2]);
        
        int x = Console.ReadLine().Split().Select(int.Parse).Sum();
        
        Console.WriteLine(9 * (a - b) / 10 - x);
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("GCVWR");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}