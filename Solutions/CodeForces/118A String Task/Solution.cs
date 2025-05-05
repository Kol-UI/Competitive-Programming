// String Task
namespace CompetitiveProgramming.CodeForces.StringTask;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        string str = Console.ReadLine()!;
        string result = "";
        foreach (char c in str)
        {
            if ("AEIOUYaeiouy".IndexOf(c) == -1)
            {
                result += ".";
                result += char.ToLower(c);
            }
        }
        Console.WriteLine(result);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("String Task");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}