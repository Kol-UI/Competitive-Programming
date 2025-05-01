// Food Buying
namespace CompetitiveProgramming.CodeForces.FoodBuying;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    static long Total(long b)
    {
        long ans = b;
        while (true)
        {
            if (b < 10)
                return ans;
            ans += b / 10;
            b = (b / 10) + (b % 10);
        }
    }

    //static void Main()
    public static void MainSolution()
    {
        int t = int.Parse(Console.ReadLine()!);
        while (t-- > 0)
        {
            long b = long.Parse(Console.ReadLine()!);
            Console.WriteLine(Total(b));
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Food Buying");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}