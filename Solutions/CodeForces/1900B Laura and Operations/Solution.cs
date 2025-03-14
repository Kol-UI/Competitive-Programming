// Laura and Operations
namespace CompetitiveProgramming.CodeForces.LauraandOperations;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            string[] input = Console.ReadLine()!.Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            int resA = (b + c) % 2 == 0 ? 1 : 0;
            int resB = (a + c) % 2 == 0 ? 1 : 0;
            int resC = (a + b) % 2 == 0 ? 1 : 0;

            Console.WriteLine($"{resA} {resB} {resC}");
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Laura and Operations");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}