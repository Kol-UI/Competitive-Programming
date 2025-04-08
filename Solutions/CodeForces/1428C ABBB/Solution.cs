// ABBB
namespace CompetitiveProgramming.CodeForces.ABBB;
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
            string str = Console.ReadLine()!;
            int b = 0, ans = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == 'A')
                {
                    if (b > 0) b--;
                    else ans++;
                }
                else b++;
            }
            ans += b % 2;
            Console.WriteLine(ans);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("ABBB");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}