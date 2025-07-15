// Square Year
namespace CompetitiveProgramming.CodeForces.SquareYear;
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
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string s = Console.ReadLine();
            int y = 1000 * (s[0] - '0') + 100 * (s[1] - '0') + 10 * (s[2] - '0') + (s[3] - '0');
            int a = -1;
            
            for (int p = 0; p * p <= y; p++)
            {
                if (p * p == y)
                {
                    a = p;
                    break;
                }
            }
            
            Console.WriteLine(a + (a >= 0 ? " 0" : ""));
        }
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
        StyleHelper.Title("Square Year");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
    }
}