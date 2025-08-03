// Little Elephant and Bits
namespace CompetitiveProgramming.CodeForces.LittleElephantandBits;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        string input = Console.ReadLine();
        int found = input.Length - 1;
        for (int k = 0; k < input.Length; k++)
        {
            if (input[k] == '0')
            {
                found = k;
                break;
            }
        }
        Console.WriteLine(input.Remove(found, 1));
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
        StyleHelper.Title("Little Elephant and Bits");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}