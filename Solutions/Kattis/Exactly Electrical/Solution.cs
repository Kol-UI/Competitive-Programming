// Exactly Electrical
namespace CompetitiveProgramming.Kattis.ExactlyElectrical;
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
        string[] firstLine = Console.ReadLine().Split();
        int a = int.Parse(firstLine[0]);
        int b = int.Parse(firstLine[1]);
        
        string[] secondLine = Console.ReadLine().Split();
        int c = int.Parse(secondLine[0]);
        int d = int.Parse(secondLine[1]);
        
        int q = int.Parse(Console.ReadLine());
        
        int dst = Math.Abs(a - c) + Math.Abs(b - d);
        
        if (dst > q || (dst % 2 != q % 2))
            Console.WriteLine("N");
        else
            Console.WriteLine("Y");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Exactly Electrical");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}