// Prime Generator


using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.SphereOnlineJudge.PrimeGenerator;

class Program
{
    //static void Main()
    static void Solution()
    {
        int t = int.Parse(Console.ReadLine()!);

        for (int i = 0; i < t; i++)
        {
            string[] input = Console.ReadLine()!.Split();
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);

            if (i > 0)
                Console.WriteLine();

            PrintPrimesInRange(m, n);
        }
    }

    static bool IsPrime(int num)
    {
        if (num < 2)
            return false;

        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }

    static void PrintPrimesInRange(int m, int n)
    {
        for (int i = m; i <= n; i++)
        {
            if (IsPrime(i)) Console.WriteLine(i);
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Prime Generator");
            ResultTester.SpecialTestCase(ProblemOrigin.SphereOnlineJudge, ProblemCategory.OtherSOJ);
        }
    }
}
