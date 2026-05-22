// Grandma Capa Knits a Scarf
namespace CompetitiveProgramming.CodeForces.GrandmaCapaKnitsaScarf;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8604
#pragma warning disable CS8600

using System;

class Program
{
    static void Main()
    {
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            long res = -1;
            for (char c = 'a'; c <= 'z'; c++)
            {
                long left = 0, right = n - 1;
                long cnt = 0;
                bool valid = true;

                while (left < right)
                {
                    if (s[(int)left] == s[(int)right])
                    {
                        left++;
                        right--;
                    }
                    else if (s[(int)left] == c)
                    {
                        left++;
                        cnt++;
                    }
                    else if (s[(int)right] == c)
                    {
                        right--;
                        cnt++;
                    }
                    else
                    {
                        valid = false;
                        break;
                    }
                }

                if (valid)
                {
                    if (res < 0 || cnt < res)
                        res = cnt;
                }
            }

            Console.WriteLine(res);
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Grandma Capa Knits a Scarf");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF1200);
    }
}