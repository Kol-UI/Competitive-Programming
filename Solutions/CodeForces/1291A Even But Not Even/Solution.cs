// Even But Not Even
namespace CompetitiveProgramming.CodeForces.EvenButNotEven;
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
            int n = int.Parse(Console.ReadLine()!);
            string str = Console.ReadLine()!;
            string ans = "";

            foreach (char c in str)
            {
                if ((c - '0') % 2 == 1)
                {
                    ans += c;
                }
                if (ans.Length > 1)
                {
                    break;
                }
            }

            if (ans.Length < 2)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(ans);
            }
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Even But Not Even");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}