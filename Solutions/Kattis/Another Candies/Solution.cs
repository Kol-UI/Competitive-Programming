// Another Candies
namespace CompetitiveProgramming.Kattis.AnotherCandies;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            long sum = 0;

            for (int j = 0; j < num; j++)
            {
                long temp = long.Parse(Console.ReadLine());
                sum = (sum + temp) % num;
            }

            if (sum % num == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}

#pragma warning restore CS8604
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Another Candies");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}