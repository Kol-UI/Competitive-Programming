// Joysticks
namespace CompetitiveProgramming.CodeForces.Joysticks;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602

using System;
using System.Linq;

public class HelloWorld
{
    static public void Main()
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int a = input[0];
        int b = input[1];
        
        if(a <= 1 && b <= 1)
        {
            Console.WriteLine("0");
        }
        else
        {
            int result = a + b - 2;
            if((a - b) % 3 == 0) result -= 1;
            Console.WriteLine(result);
        }
    }
}

#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Joysticks");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}