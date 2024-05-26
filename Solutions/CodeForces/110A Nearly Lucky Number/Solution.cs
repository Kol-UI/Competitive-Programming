// Nearly Lucky Number



using System;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
namespace CompetitiveProgramming.CodeForces.NearlyLuckyNumber
{
    class Program
    {
        //static void Main()
        static void Solution()
        {
            string n = Console.ReadLine()!;
            Console.WriteLine(IsNearlyLucky(n) ? "YES" : "NO");
        }

        static bool IsNearlyLucky(string n)
        {
            int luckyCount = 0;

            foreach (char digit in n)
            {
                if (digit == '4' || digit == '7')
                    luckyCount++;
            }

            return luckyCount > 0 && IsLucky(luckyCount);
        }

        static bool IsLucky(int n)
        {
            while (n > 0)
            {
                int digit = n % 10;
                if (digit != 4 && digit != 7)
                    return false;

                n /= 10;
            }

            return true;
        }
    }

    public class TestSolution : BaseSolution
    {
        public override void GetResult()
        {
            StyleHelper.Space();
            StyleHelper.Title("Nearly Lucky Number");
            ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF800);
        }
    }
}