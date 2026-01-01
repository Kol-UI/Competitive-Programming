// Arrays
namespace CompetitiveProgramming.CodeForces.Arrays;
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
        int na = int.Parse(firstLine[0]);
        int nb = int.Parse(firstLine[1]);
        
        string[] secondLine = Console.ReadLine().Split();
        int k = int.Parse(secondLine[0]);
        int m = int.Parse(secondLine[1]);
        
        long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        long[] b = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        
        long low = a[k - 1];
        long high = b[nb - m];
        
        Console.WriteLine(low < high ? "YES" : "NO");
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Arrays");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}