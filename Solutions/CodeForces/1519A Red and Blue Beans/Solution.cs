// Red and Blue Beans
namespace CompetitiveProgramming.CodeForces.RedandBlueBeans;
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
            var input = Console.ReadLine()!.Split();
            long l = long.Parse(input[0]);
            long r = long.Parse(input[1]);
            long d = long.Parse(input[2]);

            if (l > r)
                (l, r) = (r, l);

            if ((d + 1) * l >= r)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Red and Blue Beans");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}