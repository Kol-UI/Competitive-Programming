// DIV + MOD
namespace CompetitiveProgramming.CodeForces.DIVPlusMOD;
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
            long l = long.Parse(input[0]);
            long r = long.Parse(input[1]);
            long a = long.Parse(input[2]);

            if (l / a == r / a)
                Console.WriteLine(r / a + r % a);
            else
                Console.WriteLine(Math.Max(r / a + r % a, r / a + a - 2));
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("DIV + MOD");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}