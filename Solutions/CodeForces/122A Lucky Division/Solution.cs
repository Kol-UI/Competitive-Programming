// Lucky Division
namespace CompetitiveProgramming.CodeForces.LuckyDivision;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    static void Divisible(int num)
    {
        for (int i = 4; i < 1010; i++)
        {
            int temp = i;
            bool isValid = true;
            while (temp != 0)
            {
                int rem = temp % 10;
                temp /= 10;
                if (rem != 4 && rem != 7)
                {
                    isValid = false;
                    break;
                }
            }
            if (isValid && num % i == 0)
            {
                Console.WriteLine("YES");
                return;
            }
        }
        Console.WriteLine("NO");
    }

    //static void Main()
    public static void MainSolution()
    {
        int number = int.Parse(Console.ReadLine()!);
        Divisible(number);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Lucky Division");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1000);
    }
}