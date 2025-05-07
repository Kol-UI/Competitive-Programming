// Expression
namespace CompetitiveProgramming.CodeForces.Expression;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int a = int.Parse(Console.ReadLine()!);
        int b = int.Parse(Console.ReadLine()!);
        int c = int.Parse(Console.ReadLine()!);
        
        int res1 = a + b + c;
        int res2 = a * b * c;
        int res3 = a + b * c;
        int res4 = a * b + c;
        int res5 = (a + b) * c;
        int res6 = a * (b + c);
        
        int max = Math.Max(res1, Math.Max(res2, Math.Max(res3, Math.Max(res4, Math.Max(res5, res6)))));
        
        Console.WriteLine(max);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Expression");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}