// Divide and Multiply
namespace CompetitiveProgramming.CodeForces.DivideandMultiply;
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
        long t = long.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            long n = long.Parse(Console.ReadLine());
            long[] arr = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long mx = 0, cnt = 0, res = 0;
            foreach (long x in arr)
            {
                long temp = x;
                while (temp % 2 == 0)
                {
                    temp /= 2;
                    cnt++;
                }
                if (temp > mx)
                {
                    res += mx;
                    mx = temp;
                }
                else
                {
                    res += temp;
                }
            }
            for (long p = 0; p < cnt; p++) mx *= 2;
            res += mx;
            Console.WriteLine(res);
        }
    }
}

#pragma warning restore CS8604
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Divide and Multiply");
        ResultTester.SpecialTestCase(ProblemOrigin.CodeForces, ProblemCategory.CF900);
    }
}