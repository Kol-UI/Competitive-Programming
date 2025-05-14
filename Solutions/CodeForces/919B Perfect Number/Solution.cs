// Perfect Number
namespace CompetitiveProgramming.CodeForces.PerfectNumber;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;

using System;

class Program
{
    static void Perfect(int n)
    {
        int num = 19;
        for (int i = 0; i < n;)
        {
            int sum = 0;
            int temp = num;
            while (temp != 0)
            {
                sum += temp % 10;
                temp /= 10;
            }
            if (sum == 10)
            {
                i++;
                num++;
            }
            else
            {
                num++;
            }
        }
        Console.WriteLine(num - 1);
    }

    //static void Main()
    public static void MainSolution()
    {
        int n = int.Parse(Console.ReadLine()!);
        Perfect(n);
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Perfect Number");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1100);
    }
}