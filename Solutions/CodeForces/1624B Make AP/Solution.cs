// Make AP
namespace CompetitiveProgramming.CodeForces.MakeAP;
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
            
            bool condition1 = (2 * b - c) % a == 0 && (2 * b > c);
            bool condition2 = (2 * b - a) % c == 0 && (2 * b > a);
            bool condition3 = (a + c) % (2 * b) == 0;
            
            Console.WriteLine((condition1 || condition2 || condition3) ? "YES" : "NO");
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Make AP");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}