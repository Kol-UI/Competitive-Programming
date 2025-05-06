// AvtoBus
namespace CompetitiveProgramming.CodeForces.AvtoBus;
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
            long n = long.Parse(Console.ReadLine()!);
            if ((n & 1) == 1 || n < 4)
            {
                Console.WriteLine("-1");
                continue;
            }
            if (n == 6 || n == 4)
            {
                Console.WriteLine("1 1");
                continue;
            }

            if (n % 6 == 0)
            {
                Console.Write(n / 6 + " ");
            }
            else
            {
                long cnt = 0, temp = n;
                while (temp % 6 != 0)
                {
                    temp -= 4;
                    cnt++;
                }
                Console.Write((temp / 6) + cnt + " ");
            }

            if (n % 4 == 0)
            {
                Console.WriteLine(n / 4);
            }
            else
            {
                long cnt = 0, temp = n;
                while (temp % 4 != 0)
                {
                    temp -= 6;
                    cnt++;
                }
                Console.WriteLine((temp / 4) + cnt);
            }
        }
    }
}

public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("AvtoBus");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}