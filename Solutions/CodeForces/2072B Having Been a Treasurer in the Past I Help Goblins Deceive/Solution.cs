// Having Been a Treasurer in the Past, I Help Goblins Deceive
namespace CompetitiveProgramming.CodeForces.HavingBeenaTreasurerinthePastIHelpGoblinsDeceive;
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
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            long a = 0, b = 0;
            foreach (char c in s)
            {
                if (c == '-') a++;
                if (c == '_') b++;
            }
            long ans = b * (a / 2) * ((a + 1) / 2);
            Console.WriteLine(ans);
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
        StyleHelper.Title("Having Been a Treasurer in the Past, I Help Goblins Deceive");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}