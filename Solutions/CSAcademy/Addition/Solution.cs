// Addition


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CSAcademy.Addition;
class Solution
{
    //static void Main(String[] args)
    static void Function()
    {
        string[] input = Console.ReadLine()!.Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        int sum = a + b;

        Console.WriteLine(sum);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Addition");
        ResultTester.SpecialTestCase(ProblemOrigin.CSAcademy, ProblemCategory.TutorialCSA);
    }
}