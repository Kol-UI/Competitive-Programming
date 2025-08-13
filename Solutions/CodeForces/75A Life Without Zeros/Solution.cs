// Life Without Zeros
namespace CompetitiveProgramming.CodeForces.LifeWithoutZeros;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static long RemoveZeros(long x)
    {
        string s = x.ToString();
        string result = "";
        foreach (char c in s)
        {
            if (c != '0') result += c;
        }
        return result.Length > 0 ? long.Parse(result) : 0;
    }

    //static void Main()
    public static void MainSolution()
    {
        long a = long.Parse(Console.ReadLine());
        long b = long.Parse(Console.ReadLine());
        
        long sum = a + b;
        long convertedA = RemoveZeros(a);
        long convertedB = RemoveZeros(b);
        long convertedSum = RemoveZeros(sum);
        
        Console.WriteLine(convertedA + convertedB == convertedSum ? "YES" : "NO");
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
        StyleHelper.Title("Life Without Zeros");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}