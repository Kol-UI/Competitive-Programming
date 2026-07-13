// Modular Arithmetic
namespace CompetitiveProgramming.Kattis.ModularArithmetic;
using CompetitiveProgramming.Helpers;
using CompetitiveProgramming.Models;
using CompetitiveProgramming.TestDrivenDevelopment;
#pragma warning disable CS8602
#pragma warning disable CS8600

using System;

class Program
{
    static long ExtGcd(long a, long b, ref long x, ref long y)
    {
        if (b == 0)
        {
            x = 1;
            y = 0;
            return a;
        }

        long xx = 0, yy = 0;
        long g = ExtGcd(b, a % b, ref xx, ref yy);
        x = yy;
        y = xx - (a / b) * yy;
        return g;
    }

    static void Main()
    {
        while (true)
        {
            string line = Console.ReadLine();
            if (string.IsNullOrEmpty(line)) break;

            string[] firstLine = line.Split();
            long n = long.Parse(firstLine[0]);
            int t = int.Parse(firstLine[1]);

            if (n == 0) break;

            for (int i = 0; i < t; i++)
            {
                string[] input = Console.ReadLine().Split();
                long a = long.Parse(input[0]);
                char op = char.Parse(input[1]);
                long b = long.Parse(input[2]);

                long result = 0;

                if (op == '+')
                {
                    result = ((a + b) % n + n) % n;
                    Console.WriteLine(result);
                }
                else if (op == '-')
                {
                    result = ((a - b) % n + n) % n;
                    Console.WriteLine(result);
                }
                else if (op == '*')
                {
                    result = ((a * b) % n + n) % n;
                    Console.WriteLine(result);
                }
                else
                {
                    long binv = 0, k = 0;
                    long g = ExtGcd(b, n, ref binv, ref k);
                    binv = (binv % n + n) % n;

                    if ((b * binv) % n != 1)
                    {
                        Console.WriteLine(-1);
                        continue;
                    }

                    result = ((a * binv % n) + n) % n;
                    Console.WriteLine(result);
                }
            }
        }
    }
}

#pragma warning restore CS8600
#pragma warning restore CS8602
public class TestSolution : BaseSolution
{
    public override void GetResult()
    {
        StyleHelper.Space();
        StyleHelper.Title("Modular Arithmetic");
        ResultTester.SpecialTestCase(ProblemOrigin.Kattis, ProblemCategory.EasyKAT);
    }
}