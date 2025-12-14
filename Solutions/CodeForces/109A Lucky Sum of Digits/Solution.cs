// Lucky Sum of Digits
namespace CompetitiveProgramming.CodeForces.LuckySumofDigits;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604

using System;

class Program
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long sevens = -1, fours = -1;
        
        for (long testSevens = n / 7; testSevens >= 0; testSevens--)
        {
            long remainder = n - 7 * testSevens;
            if (remainder % 4 != 0) continue;
            long testFours = remainder / 4;
            sevens = testSevens;
            fours = testFours;
            break;
        }
        
        if (sevens >= 0 && fours >= 0)
        {
            Console.Write(new string('4', (int)fours));
            Console.Write(new string('7', (int)sevens));
        }
        else
        {
            Console.Write("-1");
        }
        Console.WriteLine();
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Lucky Sum of Digits");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}