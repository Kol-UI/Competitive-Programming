// Make it Divisible by 25
namespace CompetitiveProgramming.CodeForces.MakeitDivisiblebyTwentyFive;
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
            int n = str.Length;
            int ans = n;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int temp = (str[i] - '0') * 10 + (str[j] - '0');
                    if (temp % 25 == 0)
                    {
                        ans = Math.Min(ans, (j - i - 1) + (n - j - 1));
                    }
                }
            }
            Console.WriteLine(ans);
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Make it Divisible by 25");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}