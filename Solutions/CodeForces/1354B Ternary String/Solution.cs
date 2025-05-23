// Ternary String
namespace CompetitiveProgramming.CodeForces.TernaryString;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;
using System.Linq;

class Program
{
    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            string str = Console.ReadLine()!;
            int[] pos = { -1, -1, -1, -1 };
            int ans = int.MaxValue;
            for (int i = 0; i < str.Length; i++)
            {
                pos[str[i] - '0'] = i;
                if (pos.Skip(1).All(x => x != -1))
                {
                    ans = Math.Min(ans, pos.Skip(1).Max() - pos.Skip(1).Min() + 1);
                }
            }
            Console.WriteLine(ans == int.MaxValue ? 0 : ans);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Ternary String");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}